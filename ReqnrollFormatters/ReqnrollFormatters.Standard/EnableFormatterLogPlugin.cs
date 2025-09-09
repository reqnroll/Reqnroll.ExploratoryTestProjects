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
            args.ObjectContainer.RegisterTypeAs<FileFormatterLog, IFormatterLog>();
        };
    }

    public class FileFormatterLog : IFormatterLog
    {
        private readonly List<string> _entries = new();

        public void WriteMessage(string message)
        {
            _entries.Add($"{DateTime.Now:HH:mm:ss.fff}: {message}");
        }

        public void DumpMessages()
        {
            File.WriteAllLines("formatter_log.txt", _entries);
        }
    }
}