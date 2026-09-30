using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class TellusPulvinarNullaLeoSteps
    {
        [Given(@"orci eu augue (\d+)")]
        public void GivenNullaLitoraEuSit(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"(\d+) ""(.*)"" conubia conubia mi")]
        public void GivenAmetVitaeEleifendFaucibus(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"viverra feugiat aptent vulputate non")]
        public void WhenLitoraUrnaIpsumVitae()
        {
           AutomationStub.DoStep();
        }

        [Then(@"""(.*)"" (\d+) at (\d+) suscipit")]
        public void ThenInVestibulumMiSociosqu(string p0, int p1, int p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

        [When(@"tempus molestie ipsum massa")]
        public void WhenIntegerMalesuadaSedCondimentum()
        {
           AutomationStub.DoStep();
        }

        [When(@"""(.*)"" sapien nec iaculis massa")]
        public void WhenCondimentumAtTemporSapien(string p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
