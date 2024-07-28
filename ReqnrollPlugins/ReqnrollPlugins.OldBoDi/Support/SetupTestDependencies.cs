using BoDi;
using CalculatorApp;

namespace ReqnrollPlugins.OldBoDi.Support;
public class SetupTestDependencies
{
    public static IObjectContainer CreateServices()
    {
        var oldBoDiContainer = new ObjectContainer();

        oldBoDiContainer.RegisterTypeAs<TestCalculatorConfiguration, ICalculatorConfiguration>();
        oldBoDiContainer.RegisterTypeAs<Calculator, ICalculator>();

        return oldBoDiContainer;
    }
}
