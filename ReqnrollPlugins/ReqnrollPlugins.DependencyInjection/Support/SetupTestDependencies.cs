using CalculatorApp;
using Microsoft.Extensions.DependencyInjection;
using Reqnroll.Microsoft.Extensions.DependencyInjection;

namespace ReqnrollPlugins.DependencyInjection.Support;
public class SetupTestDependencies
{
    [ScenarioDependencies]
    public static IServiceCollection CreateServices()
    {
        var services = new ServiceCollection();

        services.AddSingleton<ICalculatorConfiguration, TestCalculatorConfiguration>();
        services.AddSingleton<ICalculator, Calculator>();

        return services;
    }
}
