using Cucumber.HtmlFormatter;
using Io.Cucumber.Messages.Types;
using Reqnroll.Formatters.Configuration;
using Reqnroll.Formatters.Html;
using Reqnroll.Formatters.RuntimeSupport;
using Reqnroll.Utils;
using System.Text.RegularExpressions;

namespace ReqnrollFormatters.CustomizedHtml;

/// <summary>
/// HTML formatter that uses custom rendering for elements in the report.
/// Based on https://github.com/cucumber/react-components?tab=readme-ov-file#custom-rendering
/// </summary>
public class CustomRenderingHtmlFormatter(IFormattersConfigurationProvider configurationProvider, IFormatterLog logger, IFileSystem fileSystem)
    : HtmlFormatter(configurationProvider, logger, fileSystem, "customRenderingHtml")
{
    private string LoadJavascriptResourceWithCustomRenderFunction(string customRenderScript)
    {
        string originalResource = new HtmlReportSettings().JavascriptResourceLoader();
        var globalVarsMatch = Regex.Match(originalResource, @"\.render\((?<reactObj>[\w\.]+)\.createElement\((?<cucComps>[\w\.]+)\.EnvelopesProvider");
        if (!globalVarsMatch.Success)
            throw new InvalidOperationException("Could not find global variables in main.js resource. The regex did not match: " + originalResource);
        var reactObj = globalVarsMatch.Groups["reactObj"].Value;
        var cucumberReactComponents = globalVarsMatch.Groups["cucComps"].Value;

        // Use customRender which completely customizes the rendering of DocString
        return
            customRenderScript +
            Regex.Replace(originalResource, @"(?<rootObj>\(0,\w+\(\d+\).createRoot\)\(document.getElementById\(""content""\)\)).render\(", "customRender(" + reactObj + "," + cucumberReactComponents + ", ${rootObj},");
    }

    protected override HtmlReportSettings GetHtmlReportSettings()
    {
        var customRenderScript =
            """
            function customRender(reactObj, cucumberReactComponents, rootObj, renderArg) {
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
            """;
        var settings = base.GetHtmlReportSettings();
        settings.JavascriptResourceLoader = () => LoadJavascriptResourceWithCustomRenderFunction(customRenderScript);
        return settings;
    }
}