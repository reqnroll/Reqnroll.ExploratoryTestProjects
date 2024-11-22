using Reqnroll;

namespace ReqnrollCalculator.Specs.StepDefinitions;

[Binding]
public sealed class CalculatorStepDefinitions
{
    private static readonly Random Rnd = new(42);

    private const bool AddRandomWait = true;
    private const int MinWaitMs = 300;
    private const int MaxWaitMs = 350;

    private readonly Calculator _calculator = new();

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

    [Given("the entered numbers are")]
    public void GivenTheEnteredNumbersAre(DataTable dataTable)
    {
        _calculator.Reset();
        foreach (var row in dataTable.Rows)
        {
            _calculator.Enter(int.Parse(row[0]));
        }
    }

    [When("the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        if (AddRandomWait)
            Thread.Sleep(MinWaitMs + Rnd.Next(MaxWaitMs - MinWaitMs));
        _calculator.Add();
    }

    [Then("the result should be {int}")]
    public void ThenTheResultShouldBe(int result)
    {
        if (_calculator.GetResult() != result)
            throw new Exception($"Expected {result}, got: {_calculator.GetResult()}");
    }
}
