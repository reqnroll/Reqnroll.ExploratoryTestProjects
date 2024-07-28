using TechTalk.SpecFlow;

namespace ExternalStepDefs;

[Binding]
public class ExternalStepDefinitions
{
    [Then("external step definitions (.*) Reqnroll work")]
    public void ThenTheResultShouldBe(int dummy)
    {
    }
}
