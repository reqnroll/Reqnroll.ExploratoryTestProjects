using Reqnroll;

namespace ReqnrollFormatters.Custom.StepDefinitions;

[Binding]
public sealed class ProjectStepDefinitions(IReqnrollOutputHelper outputHelper)
{
    [When("I do something")]
    public void WhenIDoSomething()
    {
    }

    [Then("the scenario fails")]
    public void ThenTheScenarioFails()
    {
        throw new Exception("simulated error");
    }

    [Then("nothing else matters")]
    public void ThenNothingElseMatters()
    {
    }


    [Given("the first parameter is {string}")]
    public void GivenTheFirstParameterIs(string firstParam)
    {
    }

    [Given("{int} is the second parameter")]
    public void WhenIsTheSecondParameter(int secondParam)
    {
    }

    [Then("the scenario passes")]
    public void ThenTheScenarioPasses()
    {
    }

    [When("the step generates an attachment")]
    public void WhenTheStepGeneratesAnAttachment()
    {
        outputHelper.AddAttachment("sample-image.png");
    }

    [When("the step generates a test output")]
    public void WhenTheStepGeneratesATestOutput()
    {
        outputHelper.WriteLine("this is a text" + Environment.NewLine + "this is a second line");
    }

    [BeforeScenario("@attachment")]
    public void BeforeAttachmentScenario()
    {
        outputHelper.WriteLine("before attachment scenario hook executed");
    }

    [AfterScenario("@attachment")]
    public void AfterAttachmentScenario()
    {
        outputHelper.WriteLine("after attachment scenario hook executed");
    }
}