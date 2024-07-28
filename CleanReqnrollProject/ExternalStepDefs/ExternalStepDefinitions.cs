using Reqnroll;
using System;

namespace ExternalStepDefs;

[Binding]
public class ExternalStepDefinitions
{
    [Then("external step definitions {int} Reqnroll work")]
    public void ThenTheResultShouldBe(int dummy)
    {
    }

    [Then("unused in external")]
    public void UnusedInExternal(int dummy)
    {
    }

}
