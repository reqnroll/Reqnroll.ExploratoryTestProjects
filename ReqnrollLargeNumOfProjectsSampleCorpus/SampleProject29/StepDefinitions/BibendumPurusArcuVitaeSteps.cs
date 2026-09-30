using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class BibendumPurusArcuVitaeSteps
    {
        [When(@"tincidunt ""(.*)"" vitae")]
        public void WhenPharetraEleifendOrciElit(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"cursus ""(.*)"" conubia molestie")]
        public void WhenEuLacusEratSuscipit(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"nec ligula Sed")]
        public void GivenEgestasAugueCursusNec()
        {
           AutomationStub.DoStep();
        }

        [Then(@"pulvinar (\d+) (\d+) (\d+) (\d+)")]
        public void ThenElitDapibusNuncViverra(int p0, int p1, int p2, int p3)
        {
           AutomationStub.DoStep(p0, p1, p2, p3);
        }

        [Given(@"felis ""(.*)"" quis a")]
        public void GivenNullaLiberoElitTristique(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"ad non faucibus mattis pretium")]
        public void ThenLigulaInMaecenasSed()
        {
           AutomationStub.DoStep();
        }

    }
}
