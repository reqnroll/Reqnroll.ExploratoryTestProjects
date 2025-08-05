using Reqnroll.Formatters;
using Reqnroll.Plugins;
using Reqnroll.UnitTestProvider;
using ReqnrollFormatters.CustomizedHtml;

[assembly: RuntimePlugin(typeof(CustomizedHtmlFormatterPlugin))]

namespace ReqnrollFormatters.CustomizedHtml;

public class CustomizedHtmlFormatterPlugin : IRuntimePlugin
{
    public void Initialize(RuntimePluginEvents runtimePluginEvents, RuntimePluginParameters runtimePluginParameters, UnitTestProviderConfiguration unitTestProviderConfiguration)
    {
        runtimePluginEvents.RegisterGlobalDependencies += (_, args) =>
        {
            // Register the custom themed HTML formatter
            args.ObjectContainer.RegisterTypeAs<CustomThemedHtmlFormatter, ICucumberMessageFormatter>("customThemedHtml");
            
            // Register the custom styled HTML formatter
            args.ObjectContainer.RegisterTypeAs<CustomStyledHtmlFormatter, ICucumberMessageFormatter>("customStyledHtml");
            
            // Register the custom rendering HTML formatter
            args.ObjectContainer.RegisterTypeAs<CustomRenderingHtmlFormatter, ICucumberMessageFormatter>("customRenderingHtml");
            
            // Register the custom template HTML formatter
            args.ObjectContainer.RegisterTypeAs<CustomTemplateHtmlFormatter, ICucumberMessageFormatter>("customTemplateHtml");
        };
    }
}