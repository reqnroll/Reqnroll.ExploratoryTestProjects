using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class MiInVitaeSitSteps
    {
        [Given(@"condimentum ""(.*)"" nec magna")]
        public void GivenClassLaciniaCondimentumBlandit(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"condimentum fermentum (\d+)")]
        public void WhenBlanditANullaLibero(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"libero non cursus ""(.*)""")]
        public void ThenFinibusLacusMaurisDictum(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"lobortis (\d+) augue")]
        public void ThenCondimentumCommodoPhasellusIn(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"vitae malesuada suscipit")]
        public void ThenNecPerIdSem(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"vitae tempus Curabitur")]
        public void GivenIaculisVariusEstEget()
        {
           AutomationStub.DoStep();
        }

        [Then(@"""(.*)"" (\d+) at (\d+) suscipit")]
        public void ThenInVehiculaSapienEu(string p0, int p1, int p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

        [Then(@"faucibus ligula (\d+) porta")]
        public void ThenElementumFaucibusNamPorttitor(int p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
