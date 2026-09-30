using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class SodalesScelerisqueLigulaMaurisSteps
    {
        [When(@"per mi efficitur Nulla")]
        public void WhenCongueMolestieTristiqueEu(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"finibus leo ""(.*)"" blandit")]
        public void ThenDuisLitoraTorquentPulvinar(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"vel (\d+) (\d+)")]
        public void GivenVulputateScelerisqueNequeTempus(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"nec elit ex Lorem ipsum")]
        public void WhenCondimentumIdInRisus()
        {
           AutomationStub.DoStep();
        }

        [Given(@"ut venenatis ut")]
        public void GivenDuiPerPortaFaucibus()
        {
           AutomationStub.DoStep();
        }

        [Given(@"neque tortor torquent nec")]
        public void GivenMassaCondimentumATristique()
        {
           AutomationStub.DoStep();
        }

    }
}
