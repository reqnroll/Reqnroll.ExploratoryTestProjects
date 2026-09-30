using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class AptentNequeExErosSteps
    {
        [Then(@"ante libero ut")]
        public void ThenSociosquAugueAccumsanDignissim()
        {
           AutomationStub.DoStep();
        }

        [Then(@"lorem dictum (\d+) accumsan")]
        public void ThenSedLacusPortaScelerisque(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"urna (\d+) suscipit")]
        public void ThenEuAtConsecteturNulla(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"egestas efficitur tellus")]
        public void WhenUtVenenatisLobortisAc()
        {
           AutomationStub.DoStep();
        }

        [Then(@"justo sed volutpat id ""(.*)""")]
        public void ThenSuscipitCondimentumFermentumTorquent(string p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"tempus molestie ipsum massa")]
        public void WhenFusceCondimentumDiamElit()
        {
           AutomationStub.DoStep();
        }

    }
}
