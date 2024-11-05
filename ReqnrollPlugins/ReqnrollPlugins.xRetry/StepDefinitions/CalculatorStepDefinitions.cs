using CalculatorApp;
using ReqnrollPlugins.XRetryPlugin.Support;
using System.Collections;

namespace ReqnrollPlugins.XRetryPlugin.StepDefinitions;

[Binding]
public sealed class CalculatorStepDefinitions
{
    private readonly ScenarioContext _scenarioContext;
    private readonly ICalculator _calculator;

    public CalculatorStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
        _calculator = new Calculator(new TestCalculatorConfiguration());
    }

    [Given("the first number is {int}")]
    public void GivenTheFirstNumberIs(int number)
    {
        _calculator.Reset();
        _calculator.Enter(number);
    }

    [Given("the second number is {int}")]
    public void GivenTheSecondNumberIs(int number)
    {
        _calculator.Enter(number);
    }

    [When("the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        _calculator.Add();
    }

    [When("the two numbers are multiplied")]
    public void WhenTheTwoNumbersAreMultiplied()
    {
        _calculator.Multiply();
    }

    [Then("the result should be {int}")]
    public void ThenTheResultShouldBe(int result)
    {
        Assert.Equal(result, _calculator.GetResult());
    }

    private const int RetryCount = 3;
    private static readonly Dictionary<string, int> RemainingRetries = new();

    private string GetScenarioTitle(ScenarioContext scenarioContext)
    {
        if (scenarioContext.ScenarioInfo.Arguments == null || scenarioContext.ScenarioInfo.Arguments.Count == 0)
            return scenarioContext.ScenarioInfo.Title;

        return $"{scenarioContext.ScenarioInfo.Title} / {string.Join(",", scenarioContext.ScenarioInfo.Arguments.OfType<DictionaryEntry>().Select(a => a.Value))}";
    }

    [Then("the result should be around {int}")]
    public void ThenTheResultShouldBeAround(int result)
    {
        var scenarioTitle = GetScenarioTitle(_scenarioContext);
        if (!RemainingRetries.TryGetValue(scenarioTitle, out var remainingRetries))
        {
            remainingRetries = RetryCount;
        }
        result -= (--remainingRetries);
        RemainingRetries[scenarioTitle] = remainingRetries;
        Assert.Equal(result, _calculator.GetResult());
    }
}
