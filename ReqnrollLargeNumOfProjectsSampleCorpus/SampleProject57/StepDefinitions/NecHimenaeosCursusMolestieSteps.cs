using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class NecHimenaeosCursusMolestieSteps
    {
        [When(@"egestas efficitur tellus")]
        public void WhenRisusUltriciesAcTortor()
        {
           AutomationStub.DoStep();
        }

        [Given(@"condimentum commodo nec iaculis")]
        public void GivenEgestasVelEnimRisus()
        {
           AutomationStub.DoStep();
        }

        [When(@"""(.*)"" sapien nec iaculis massa")]
        public void WhenCongueEtEuismodQuis(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"commodo et conubia")]
        public void WhenIpsumEratDonecBlandit()
        {
           AutomationStub.DoStep();
        }

    }
}
