using Reqnroll.Formatters;
using Reqnroll.Plugins;
using Reqnroll.UnitTestProvider;
using ReqnrollFormatters.Custom;

[assembly: RuntimePlugin(typeof(CustomFormatterPlugin))]

namespace ReqnrollFormatters.Custom;

public class CustomFormatterPlugin : IRuntimePlugin
{
    public void Initialize(RuntimePluginEvents runtimePluginEvents, RuntimePluginParameters runtimePluginParameters, UnitTestProviderConfiguration unitTestProviderConfiguration)
    {
        runtimePluginEvents.RegisterGlobalDependencies += (_, args) =>
        {
            args.ObjectContainer.RegisterTypeAs<CustomFormatter, ICucumberMessageFormatter>("custom");
        };
    }
}