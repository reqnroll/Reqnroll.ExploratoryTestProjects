using Reqnroll.Plugins;
using Reqnroll.UnitTestProvider;

// Remove the comment from the line below to enable the formatter logger
// [assembly: RuntimePlugin(typeof(Reqnroll.Formatters.RuntimeSupport.EnableFormatterLogPlugin))]

#pragma warning disable IDE0130
namespace Reqnroll.Formatters.RuntimeSupport;
#pragma warning restore IDE0130

public class EnableFormatterLogPlugin : IRuntimePlugin
{
    public void Initialize(RuntimePluginEvents runtimePluginEvents, RuntimePluginParameters runtimePluginParameters, UnitTestProviderConfiguration unitTestProviderConfiguration)
    {
        runtimePluginEvents.CustomizeGlobalDependencies += (_, args) =>
        {
            args.ObjectContainer.RegisterTypeAs<TraceListenerFormatterLog, IFormatterLog>();
        };
    }
}