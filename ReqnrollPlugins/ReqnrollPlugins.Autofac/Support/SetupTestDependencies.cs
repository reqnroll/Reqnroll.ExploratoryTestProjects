using Autofac;
using CalculatorApp;
using Reqnroll.Autofac.ReqnrollPlugin;
using Reqnroll.Autofac;

namespace ReqnrollPlugins.Autofac.Support;
public class SetupTestDependencies
{
    [GlobalDependencies]
    public static void SetupGlobalContainer(ContainerBuilder containerBuilder)
    {
        // Register globally scoped runtime dependencies
        containerBuilder
            .RegisterType<TestCalculatorConfiguration>()
            .As<ICalculatorConfiguration>()
            .SingleInstance();
    }

    [ScenarioDependencies]
    public static void SetupScenarioContainer(ContainerBuilder containerBuilder)
    {
        // Register scenario scoped runtime dependencies
        containerBuilder
            .RegisterType<Calculator>()
            .As<ICalculator>()
            .SingleInstance();

        // register binding classes
        containerBuilder.AddReqnrollBindings<SetupTestDependencies>();
    }
}
