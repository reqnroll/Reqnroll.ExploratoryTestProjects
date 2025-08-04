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
            args.ObjectContainer.RegisterTypeAs<CustomizedHtmlFormatter, ICucumberMessageFormatter>("customizedHtml");
        };
    }
}