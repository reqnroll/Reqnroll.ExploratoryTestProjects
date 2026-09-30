using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class LigulaUtQuamConsequatSteps
    {
        [When(@"""(.*)"" sapien nec iaculis massa")]
        public void WhenFelisDonecMalesuadaLigula(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"libero in sit suscipit diam")]
        public void WhenNecElitPhasellusSollicitudin()
        {
           AutomationStub.DoStep();
        }

        [Then(@"ante sapien nec")]
        public void ThenLobortisEuSitAnte()
        {
           AutomationStub.DoStep();
        }

        [When(@"per mi efficitur Nulla")]
        public void WhenInSagittisBlanditPulvinar(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"lorem dictum (\d+) accumsan")]
        public void ThenPhasellusLitoraNibhCondimentum(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"mauris vel ""(.*)"" felis")]
        public void GivenSedSuspendisseAccumsanUt(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"(\d+) molestie odio (\d+) dolor")]
        public void GivenVitaeSuscipitInLitora(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"vitae Nam Curabitur mi viverra")]
        public void GivenEuErosVestibulumSit()
        {
           AutomationStub.DoStep();
        }

        [When(@"nulla nec dui (\d+)")]
        public void WhenSitMolestieAA(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"""(.*)"" dui a")]
        public void ThenIpsumPulvinarSitEfficitur(string p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
