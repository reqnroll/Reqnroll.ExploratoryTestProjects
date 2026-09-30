using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class UtViverraVestibulumEgestasSteps
    {
        [Then(@"Curabitur Aliquam orci accumsan id")]
        public void ThenSociosquUtBlanditPorta()
        {
           AutomationStub.DoStep();
        }

        [Then(@"justo sed volutpat id ""(.*)""")]
        public void ThenErosPorttitorScelerisqueIn(string p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"eleifend libero vitae")]
        public void GivenElementumPhasellusLectusLorem()
        {
           AutomationStub.DoStep();
        }

        [When(@"""(.*)"" sapien nec iaculis massa")]
        public void WhenMiCursusSedConubia(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"In ligula vitae")]
        public void WhenMolestieElitFermentumDignissim()
        {
           AutomationStub.DoStep();
        }

        [Then(@"Nunc pulvinar Sed")]
        public void ThenEgestasCommodoDignissimCursus()
        {
           AutomationStub.DoStep();
        }

        [Given(@"nunc augue felis cursus")]
        public void GivenCommodoVulputateLectusPlacerat(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"venenatis amet id in")]
        public void ThenClassAliquamNibhImperdiet()
        {
           AutomationStub.DoStep();
        }

    }
}
