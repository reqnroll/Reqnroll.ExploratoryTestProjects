using Cucumber.HtmlFormatter;
using Io.Cucumber.Messages.Types;
using Reqnroll.Formatters.Configuration;
using Reqnroll.Formatters.Html;
using Reqnroll.Formatters.RuntimeSupport;
using Reqnroll.Utils;
using System.Text.RegularExpressions;

namespace ReqnrollFormatters.CustomizedHtml;

/// <summary>
/// HTML formatter that applies custom styles to elements in the report.
/// Based on https://github.com/cucumber/react-components?tab=readme-ov-file#custom-styles
/// </summary>
public class CustomStyledHtmlFormatter(IFormattersConfigurationProvider configurationProvider, IFormatterLog logger, IFileSystem fileSystem)
    : HtmlFormatter(configurationProvider, logger, fileSystem, "customStyledHtml")
{
    private class CustomStyledResourceProvider : IResourceProvider
    {
        private readonly IResourceProvider _baseResourceProvider = new DefaultResourceProvider();

        public string GetTemplateResource()
        {
            // No template customization needed for custom styles
            return _baseResourceProvider.GetTemplateResource();
        }

        public string GetCssResource()
        {
            string originalResource = _baseResourceProvider.GetCssResource();
            // Add custom style for docstring
            return originalResource + "\n" +
                   """
                   /* Custom styles, see https://github.com/cucumber/react-components?tab=readme-ov-file#custom-styles */
                   .acme-docstring {
                     font-weight: bold;
                     font-style: italic;
                     background-color: black;
                     color: hotpink;
                     text-shadow: 1px 1px 2px white;
                     padding: 10px;
                   }
                   """;
        }

        public string GetJavaScriptResource()
        {
            string originalResource = _baseResourceProvider.GetJavaScriptResource();
            var globalVarsMatch = Regex.Match(originalResource, @"\.render\((?<reactObj>[\w\.]+)\.createElement\((?<cucComps>[\w\.]+)\.EnvelopesProvider");
            if (!globalVarsMatch.Success)
                throw new InvalidOperationException("Could not find global variables in main.js resource. The regex did not match: " + originalResource);
            var reactObj = globalVarsMatch.Groups["reactObj"].Value;
            var cucumberReactComponents = globalVarsMatch.Groups["cucComps"].Value;

            // Use customRender which applies a custom style class
            return
                """
                function customRender(reactObj, cucumberReactComponents, rootObj, renderArg) {
                  var customRenderArg = 
                    reactObj.createElement(cucumberReactComponents.CustomRendering, {
                        overrides: {
                          DocString: {
                            docString: 'acme-docstring'
                          }
                        }
                      }, 
                      renderArg
                    );
                  rootObj.render(customRenderArg);
                }
                
                """ + 
                Regex.Replace(originalResource, @"(?<rootObj>\(0,\w+\(\d+\).createRoot\)\(document.getElementById\(""content""\)\)).render\(", "customRender(" + reactObj + "," + cucumberReactComponents + ", ${rootObj},");
        }
    }

    protected override MessagesToHtmlWriter CreateMessagesToHtmlWriter(Stream stream, Func<StreamWriter, Envelope, Task> asyncStreamSerializer)
    {
        var customResourceProvider = new CustomStyledResourceProvider();
        return new MessagesToHtmlWriter(stream, asyncStreamSerializer, customResourceProvider);
    }
}