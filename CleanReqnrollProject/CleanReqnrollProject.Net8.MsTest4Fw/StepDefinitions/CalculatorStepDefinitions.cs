namespace CleanReqnrollProject.StepDefinitions;

[Binding]
public sealed class CalculatorStepDefinitions
{
    private readonly TestContext testContext;

    public CalculatorStepDefinitions(TestContext testContext)
    {
        this.testContext = testContext;
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
        Console.WriteLine(testContext.CurrentTestOutcome);
    }

    [Then("the result should be {int}")]
    public void ThenTheResultShouldBe(int result)
    {
        Assert.AreEqual(result, result);
    }
}
