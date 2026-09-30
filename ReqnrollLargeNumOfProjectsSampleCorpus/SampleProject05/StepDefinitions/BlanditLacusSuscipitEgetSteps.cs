using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class BlanditLacusSuscipitEgetSteps
    {
        [When(@"(\d+) erat Duis")]
        public void WhenInANequeIn(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"vitae suscipit Phasellus (\d+)")]
        public void ThenAptentErosScelerisqueSed(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"cursus iaculis vestibulum")]
        public void GivenBlanditErosNullaDignissim()
        {
           AutomationStub.DoStep();
        }

        [Given(@"(\d+) in quis volutpat")]
        public void GivenVelSuspendisseEtVulputate(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"suscipit risus tortor")]
        public void ThenInNullaSemMolestie()
        {
           AutomationStub.DoStep();
        }

        [Then(@"(\d+) augue urna finibus eu")]
        public void ThenEtBibendumRisusMassa(int p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
