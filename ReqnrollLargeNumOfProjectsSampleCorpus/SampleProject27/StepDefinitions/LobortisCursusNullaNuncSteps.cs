using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class LobortisCursusNullaNuncSteps
    {
        [Then(@"(\d+) ""(.*)"" ""(.*)""")]
        public void ThenAliquetConubiaErosLorem(int p0, string p1, string p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

        [When(@"per mi efficitur Nulla")]
        public void WhenDolorCrasIaculisScelerisque(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"Fusce ""(.*)"" sit")]
        public void ThenTemporAtPhasellusScelerisque(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"enim Sed sed venenatis")]
        public void WhenInceptosCondimentumFinibusVel()
        {
           AutomationStub.DoStep();
        }

        [Then(@"auctor sit (\d+) congue")]
        public void ThenSedVulputatePurusSuspendisse(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"viverra feugiat aptent vulputate non")]
        public void WhenRhoncusLobortisAdRhoncus()
        {
           AutomationStub.DoStep();
        }

        [Then(@"condimentum lacinia blandit")]
        public void ThenIpsumLitoraEfficiturDonec()
        {
           AutomationStub.DoStep();
        }

        [Then(@"purus In Quisque")]
        public void ThenPorttitorRisusErosCondimentum(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
