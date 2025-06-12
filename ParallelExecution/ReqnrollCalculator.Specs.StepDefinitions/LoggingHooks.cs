using Reqnroll;
using System.Collections;
using System.Diagnostics;

namespace ReqnrollCalculator.Specs.StepDefinitions;

[Binding]
public class LoggingHooks
{
    private static readonly Stopwatch Stopwatch = new();
    private static readonly object LockObj = new();
    private static readonly string LogFileName = $"parallel_log_{typeof(CalculatorStepDefinitions).Assembly.GetName().Name}.txt";

    private static void AppendLogMessage(string message, ITestRunner? testRunner = null, bool newLineAfter = false)
    {
        var timestamp = Stopwatch.Elapsed;
        lock (LockObj)
        {
            var line = $"{timestamp:c} {testRunner?.TestWorkerId ?? "-"}/#{Thread.CurrentThread.ManagedThreadId:D2}: {message}";
            File.AppendAllLines(LogFileName, newLineAfter ? [line, ""] : [line]);
        }
    }

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
}