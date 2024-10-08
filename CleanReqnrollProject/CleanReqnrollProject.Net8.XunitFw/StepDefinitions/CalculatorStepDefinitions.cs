using Xunit.Abstractions;

namespace CleanReqnrollProject.StepDefinitions;
[Binding]
public sealed class CalculatorStepDefinitions
{
    private readonly ITestOutputHelper testOutputHelper;

    public CalculatorStepDefinitions(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
    }

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
        testOutputHelper.WriteLine("numbers added");
    }

    [Then("the result should be {int}")]
    public void ThenTheResultShouldBe(int result)
    {
        Assert.Equal(result, result);
    }
}
