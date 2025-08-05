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
    private class ThemedResourceProvider : IResourceProvider
    {
        private readonly IResourceProvider _baseResourceProvider = new DefaultResourceProvider();

        public string GetTemplateResource()
        {
            string originalResource = _baseResourceProvider.GetTemplateResource();
            // Add dark-theme class to the content div
            return originalResource.Replace("<div id=\"content\">", "<div id='content' class='dark-theme'>");
        }

        public string GetCssResource()
        {
            string originalResource = _baseResourceProvider.GetCssResource();
            // Add dark theme CSS customization
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
                   """;
        }

        public string GetJavaScriptResource()
        {
            // No JavaScript customization needed for theming
            return _baseResourceProvider.GetJavaScriptResource();
        }
    }

    protected override MessagesToHtmlWriter CreateMessagesToHtmlWriter(Stream stream, Func<StreamWriter, Envelope, Task> asyncStreamSerializer)
    {
        var customResourceProvider = new ThemedResourceProvider();
        return new MessagesToHtmlWriter(stream, asyncStreamSerializer, customResourceProvider);
    }
}