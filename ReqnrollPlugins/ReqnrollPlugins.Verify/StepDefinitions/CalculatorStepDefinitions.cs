using CalculatorApp;
using ReqnrollPlugins.Verify.Support;

namespace ReqnrollPlugins.Verify.StepDefinitions;

[Binding]
public sealed class CalculatorStepDefinitions
{
    private readonly ICalculator _calculator;

    public CalculatorStepDefinitions()
    {
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
    public async Task ThenTheResultShouldBe(int result)
    {
        Assert.Equal(result, _calculator.GetResult());
        await Verifier.Verify(_calculator.GetResult());
    }
}
