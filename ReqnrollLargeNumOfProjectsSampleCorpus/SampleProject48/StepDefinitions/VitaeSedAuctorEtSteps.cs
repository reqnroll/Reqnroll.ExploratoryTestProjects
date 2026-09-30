using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class VitaeSedAuctorEtSteps
    {
        [Then(@"condimentum lacinia blandit")]
        public void ThenLeoDuiPurusSuspendisse()
        {
           AutomationStub.DoStep();
        }

        [When(@"per mi efficitur Nulla")]
        public void WhenNuncMassaOdioAd(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"Fusce ""(.*)"" sit")]
        public void ThenIdLuctusBibendumSuspendisse(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"nec scelerisque porta (\d+) iaculis")]
        public void ThenPerInterdumMassaMollis(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"""(.*)"" sapien nec iaculis massa")]
        public void WhenSemSapienSuspendisseNulla(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"laoreet ""(.*)"" Quisque lobortis blandit")]
        public void GivenVitaeInRisusAmet(string p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
