using System.Text.RegularExpressions;
using Cucumber.HtmlFormatter;
using Io.Cucumber.Messages.Types;
using Reqnroll.Formatters.Configuration;
using Reqnroll.Formatters.Html;
using Reqnroll.Formatters.RuntimeSupport;
using Reqnroll.Utils;

namespace ReqnrollFormatters.CustomizedHtml;

public class CustomizedHtmlFormatter(IFormattersConfigurationProvider configurationProvider, IFormatterLog logger, IFileSystem fileSystem)
    : HtmlFormatter(configurationProvider, logger, fileSystem, "customizedHtml")
{
    private class CustomizedResourceProvider : IResourceProvider
    {
        private readonly IResourceProvider _baseResourceProvider = new DefaultResourceProvider();

        public string GetTemplateResource()
        {
            string originalResource = _baseResourceProvider.GetTemplateResource();
            return originalResource.Replace("<div id=\"content\">", "<div id='content' class='dark-theme'>");
        }

        public string GetCssResource()
        {
            string originalResource = _baseResourceProvider.GetCssResource();
            return originalResource + "\n" +
                   """
                   /* Custom theme, see https://github.com/cucumber/react-components?tab=readme-ov-file#theming */
                   .dark-theme {
                     background-color: #1d1d26;
                     color: #c9c9d1;
                     --cucumber-anchor-color: #4caaee;
                     --cucumber-keyword-color: #d89077;
                     --cucumber-parameter-color: #4caaee;
                     --cucumber-tag-color: #85a658;
                     --cucumber-docstring-color: #66a565;
                     --cucumber-error-background-color: #cf6679;
                     --cucumber-error-text-color: #222;
                     --cucumber-code-background-color: #282a36;
                     --cucumber-code-text-color: #f8f8f2;
                     --cucumber-panel-background-color: #282a36;
                     --cucumber-panel-accent-color: #313442;
                     --cucumber-panel-text-color: #f8f8f2;
                   }
                   
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
            return
                """
                function customRender0(reactObj, cucumberReactComponents, rootObj, renderArg) {
                  rootObj.render(renderArg);
                }
                function customRender2(reactObj, cucumberReactComponents, rootObj, renderArg) {
                  console.log(reactObj);
                  console.log(cucumberReactComponents);
                  console.log(rootObj);
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
                
                function customRender(reactObj, cucumberReactComponents, rootObj, renderArg) {
                  console.log(reactObj);
                  console.log(cucumberReactComponents);
                  console.log(rootObj);
                  var customRenderArg = 
                    reactObj.createElement(cucumberReactComponents.CustomRendering, {
                        overrides: {
                          DocString: (props) => (
                              reactObj.createElement(
                                reactObj.Fragment,
                                null,
                                reactObj.createElement(
                                  "p",
                                  null,
                                  "I am going to render this doc string in a textarea:"
                                ),
                                reactObj.createElement(
                                  "textarea",
                                  null,
                                  props.docString.content
                                )
                              )
                            )
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
        // Create a custom resource provider that internally handles the default resource provider
        var customResourceProvider = new CustomizedResourceProvider();
        
        // Create the writer with the custom resource provider
        return new MessagesToHtmlWriter(stream, asyncStreamSerializer, customResourceProvider);
    }
}