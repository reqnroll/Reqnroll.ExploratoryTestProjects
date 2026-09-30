using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class RisusElementumLoremLiberoSteps
    {
        [Then(@"commodo (\d+) ligula commodo urna")]
        public void ThenCurabiturDuisMorbiPellentesque(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"dapibus ipsum (\d+) molestie")]
        public void WhenUtMiNostraEuismod(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"enim Sed sed venenatis")]
        public void WhenEtEuEgestasEu()
        {
           AutomationStub.DoStep();
        }

        [Then(@"""(.*)"" interdum Quisque (\d+)")]
        public void ThenEnimFaucibusVenenatisVitae(string p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"(\d+) lacus porta scelerisque")]
        public void ThenSuscipitRisusMassaVestibulum(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"(\d+) elementum nec sit")]
        public void WhenMagnaVulputatePhasellusSem(int p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
