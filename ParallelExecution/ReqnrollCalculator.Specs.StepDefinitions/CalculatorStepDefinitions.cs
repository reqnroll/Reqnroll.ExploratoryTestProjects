using System.Collections;
using System.Diagnostics;
using System.Reflection;
using Reqnroll;

namespace ReqnrollCalculator.Specs.StepDefinitions;

[Binding]
public sealed class CalculatorStepDefinitions
{
    private static readonly Stopwatch Stopwatch = new();
    private static readonly object LockObj = new();
    private static readonly Random Rnd = new();
    private static readonly string LogFileName = $"parallel_log_{typeof(CalculatorStepDefinitions).Assembly.GetName().Name}.txt";

    private static void AppendLogMessage(string message, ITestRunner? testRunner = null, bool newLineAfter = false)
    {
        var timestamp = Stopwatch.Elapsed;
        lock (LockObj)
        {
            var line = $"{timestamp:c} {testRunner?.TestWorkerId ?? "-"}: {message}";
            File.AppendAllLines(LogFileName, newLineAfter ? [line, ""] : [line]);
        }
    }

    private const bool AddRandomWait = true;
    private const int MinWaitMs = 100;
    private const int MaxWaitMs = 150;

    private readonly Calculator _calculator = new();

    [BeforeTestRun]
    public static void RunStart()
    {
        Stopwatch.Start();
        AppendLogMessage("BeforeTestRun");
    }

    [AfterTestRun]
    public static void RunEnd()
    {
        AppendLogMessage("AfterTestRun", newLineAfter: true);
    }

    [BeforeFeature]
    public static void FeatureStart(FeatureContext featureContext, ITestRunner testRunner)
    {
        AppendLogMessage($"  BeforeFeature: {featureContext.FeatureInfo.Title}", testRunner);
    }

    [AfterFeature]
    public static void FeatureEnd(FeatureContext featureContext, ITestRunner testRunner)
    {
        AppendLogMessage($"  AfterFeature:  {featureContext.FeatureInfo.Title}", testRunner);
    }

    private string GetScenarioTitle(ScenarioContext scenarioContext)
    {
        if (scenarioContext.ScenarioInfo.Arguments == null || scenarioContext.ScenarioInfo.Arguments.Count == 0)
            return scenarioContext.ScenarioInfo.Title;

        return $"{scenarioContext.ScenarioInfo.Title} / {string.Join(",", scenarioContext.ScenarioInfo.Arguments.OfType<DictionaryEntry>().Select(a => a.Value))}";
    }

    [BeforeScenario]
    public void ScenarioStart(FeatureContext featureContext, ScenarioContext scenarioContext, ITestRunner testRunner)
    {
        AppendLogMessage($"    BeforeScenario: {featureContext.FeatureInfo.Title} / {GetScenarioTitle(scenarioContext)}", testRunner);
    }

    [AfterScenario]
    public void ScenarioEnd(FeatureContext featureContext, ScenarioContext scenarioContext, ITestRunner testRunner)
    {
        AppendLogMessage($"    AfterScenario:  {featureContext.FeatureInfo.Title} / {GetScenarioTitle(scenarioContext)}", testRunner);
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
