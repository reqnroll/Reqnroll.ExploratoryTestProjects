using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class PorttitorPortaElitInSteps
    {
        [Given(@"egestas porta tortor")]
        public void GivenEuismodVitaeBibendumNisi(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"in In id")]
        public void ThenCondimentumVelEfficiturSed(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"(\d+) nec vulputate eleifend blandit")]
        public void GivenPortaJustoMagnaEget(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"In pretium ligula consequat orci")]
        public void WhenVariusMalesuadaNonIn()
        {
           AutomationStub.DoStep();
        }

        [Then(@"mauris eu Sed")]
        public void ThenAliquetInSemperIn(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"venenatis id laoreet ""(.*)"" venenatis")]
        public void WhenAmetDuiVulputateOrci(string p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
