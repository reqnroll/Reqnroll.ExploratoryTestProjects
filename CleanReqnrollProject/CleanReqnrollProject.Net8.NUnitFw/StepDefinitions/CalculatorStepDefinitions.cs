using NUnit.Framework;

namespace CleanReqnrollProject.StepDefinitions;
[Binding]
public sealed class CalculatorStepDefinitions
{
    [Given("the first number is {int}")]
    public void GivenTheFirstNumberIs(int number)
    {
    }

    [Given("the second number is {int}")]
    public void GivenTheSecondNumberIs(int number)
    {
    }

    [When("the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        TestContext.WriteLine("numbers added");
    }

    [Then("the result should be {int}")]
    public void ThenTheResultShouldBe(int result)
    {
    }
}
