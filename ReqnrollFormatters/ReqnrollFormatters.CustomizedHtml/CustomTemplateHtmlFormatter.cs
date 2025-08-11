using System.Reflection;
using Cucumber.HtmlFormatter;
using Io.Cucumber.Messages.Types;
using Reqnroll.Formatters.Configuration;
using Reqnroll.Formatters.Html;
using Reqnroll.Formatters.RuntimeSupport;
using Reqnroll.Utils;

namespace ReqnrollFormatters.CustomizedHtml;

/// <summary>
/// HTML formatter that uses completely custom resources built from templates.
/// This demonstrates a complete redesign of the HTML report.
/// </summary>
public class CustomTemplateHtmlFormatter(IFormattersConfigurationProvider configurationProvider, IFormatterLog logger, IFileSystem fileSystem)
    : HtmlFormatter(configurationProvider, logger, fileSystem, "customTemplateHtml")
{
    protected override HtmlReportSettings GetHtmlReportSettings()
    {
        var settings = base.GetHtmlReportSettings();
        settings.JavascriptResourceLoader = () => LoadEmbeddedResource("main.js");
        settings.CssResourceLoader = () => LoadEmbeddedResource("main.css");
        return settings;
    }

    private string LoadEmbeddedResource(string resourceName)
    {
        // Load the resource from the embedded resources in this assembly
        var assembly = Assembly.GetExecutingAssembly();
        var fullResourceName = $"{assembly.GetName().Name}.Resources.{resourceName}";

        using var stream = assembly.GetManifestResourceStream(fullResourceName);
        if (stream == null)
            throw new InvalidOperationException($"Could not find embedded resource '{fullResourceName}'");

        using var reader = new StreamReader(stream);
        return reader.ReadToEnd();
    }
}