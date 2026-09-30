using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class EuPortaAtCommodoSteps
    {
        [When(@"""(.*)"" sapien nec iaculis massa")]
        public void WhenPretiumDapibusSuscipitElementum(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"Phasellus (\d+) interdum metus")]
        public void WhenNonAuctorLectusDiam(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"eleifend libero vitae")]
        public void GivenEratLaciniaScelerisqueSociosqu()
        {
           AutomationStub.DoStep();
        }

        [When(@"tempus porta in justo id")]
        public void WhenNuncSodalesPlaceratPretium()
        {
           AutomationStub.DoStep();
        }

        [When(@"lacinia dictum (\d+)")]
        public void WhenFermentumInMollisMagna(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"""(.*)"" (\d+) at (\d+) suscipit")]
        public void ThenTristiqueIdImperdietPretium(string p0, int p1, int p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

    }
}
