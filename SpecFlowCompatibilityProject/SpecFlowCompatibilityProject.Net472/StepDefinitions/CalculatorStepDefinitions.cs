using System;
using System.Configuration;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace UpgradedReqnrollProject.StepDefinitions;

[Binding]
public sealed class CalculatorStepDefinitions
{
    private readonly ScenarioContext _scenarioContext;
    private readonly ISpecFlowOutputHelper _outputHelper;
    private readonly Calculator _calculator = new();

    public CalculatorStepDefinitions(ScenarioContext scenarioContext, ISpecFlowOutputHelper outputHelper)
    {
        _scenarioContext = scenarioContext;
        _outputHelper = outputHelper;
    }

    [BeforeScenario("@mytag")]
    public void Before()
    {
        _outputHelper.WriteLine("This is from Before");
    }

    [StepArgumentTransformation("(.*)", Name = "IntArray")]
    public int[] ConvertCommaSeparatedInts(string value)
    {
        return value.Split(',').Select(int.Parse).ToArray();
    }

    [Given("the first number is (.*)")]
    public void GivenTheFirstNumberIs(int number)
    {
        _outputHelper.WriteLine(_scenarioContext.ScenarioInfo.Title);
        _calculator.Enter(number);
        throw new Exception();
    }

    [Given("the second number is (.*)")]
    public void GivenTheSecondNumberIs(int number)
    {
        _calculator.Enter(number);
    }

    [Given("the numbers are {IntArray}")]
    public void GivenTheNumbersAre(int[] numbers)
    {
        foreach (var number in numbers)
        {
            _calculator.Enter(number);
        }
    }

    [When("the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        _calculator.Add();
    }

    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(int result)
    {
        Assert.That(_calculator.Result, Is.EqualTo(result));
    }
}
