using CalculatorApp;
using CustomPlugins.TagDecoratorGeneratorPlugin.Test.Support;
using NUnit.Framework;

namespace CustomPlugins.TagDecoratorGeneratorPlugin.Test.StepDefinitions;

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
        // test if the plugin worked
        Assert.AreEqual(ApartmentState.MTA, Thread.CurrentThread.GetApartmentState());
    }

    [When("the two numbers are multiplied")]
    public void WhenTheTwoNumbersAreMultiplied()
    {
        _calculator.Multiply();
        // test if the plugin worked
        Assert.AreEqual(ApartmentState.STA, Thread.CurrentThread.GetApartmentState());
    }

    [Then("the result should be {int}")]
    public void ThenTheResultShouldBe(int result)
    {
        Assert.AreEqual(result, _calculator.GetResult());
    }
}
