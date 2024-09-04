using CustomPlugins.TagDecoratorGeneratorPlugin.ReqnrollPlugin;
using Reqnroll.Generator.Plugins;
using Reqnroll.Generator.UnitTestConverter;
using Reqnroll.Infrastructure;
using Reqnroll.UnitTestProvider;

[assembly: GeneratorPlugin(typeof(CustomGeneratorPlugin))]

namespace CustomPlugins.TagDecoratorGeneratorPlugin.ReqnrollPlugin;

public class CustomGeneratorPlugin : IGeneratorPlugin
{
    public void Initialize(GeneratorPluginEvents generatorPluginEvents, GeneratorPluginParameters generatorPluginParameters,
        UnitTestProviderConfiguration unitTestProviderConfiguration)
    {
        generatorPluginEvents.RegisterDependencies += RegisterDependencies;
    }

    private void RegisterDependencies(object sender, RegisterDependenciesEventArgs eventArgs)
    {
        eventArgs.ObjectContainer.RegisterTypeAs<StaApartmentStateTagDecorator, ITestMethodTagDecorator>(StaApartmentStateTagDecorator.TAG_NAME);
    }
}
