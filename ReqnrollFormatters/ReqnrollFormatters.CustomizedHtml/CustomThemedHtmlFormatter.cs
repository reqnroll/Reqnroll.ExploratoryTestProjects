using Cucumber.HtmlFormatter;
using Io.Cucumber.Messages.Types;
using Reqnroll.Formatters.Configuration;
using Reqnroll.Formatters.Html;
using Reqnroll.Formatters.RuntimeSupport;
using Reqnroll.Utils;

namespace ReqnrollFormatters.CustomizedHtml;

/// <summary>
/// HTML formatter that customizes the theme of the report.
/// Based on https://github.com/cucumber/react-components?tab=readme-ov-file#theming
/// </summary>
public class CustomThemedHtmlFormatter(IFormattersConfigurationProvider configurationProvider, IFormatterLog logger, IFileSystem fileSystem)
    : HtmlFormatter(configurationProvider, logger, fileSystem, "customThemedHtml")
{
    protected override HtmlReportSettings GetHtmlReportSettings()
    {
        var settings = base.GetHtmlReportSettings();
        settings.CustomCss = """
                             /* Custom theme, see https://github.com/cucumber/react-components?tab=readme-ov-file#theming */
                             #content {
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
                             """;
        return settings;
    }
}