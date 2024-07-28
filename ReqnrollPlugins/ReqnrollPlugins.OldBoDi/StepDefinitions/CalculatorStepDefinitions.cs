using CalculatorApp;

namespace ReqnrollPlugins.OldBoDi.StepDefinitions;

[Binding]
public sealed class CalculatorStepDefinitions
{
    private readonly ICalculator _calculator;

    public CalculatorStepDefinitions(ICalculator calculator)
    {
        _calculator = calculator;
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
        Assert.AreEqual(result, _calculator.GetResult());
    }
}
