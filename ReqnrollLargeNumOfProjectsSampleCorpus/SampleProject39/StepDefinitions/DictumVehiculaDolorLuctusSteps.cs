using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class DictumVehiculaDolorLuctusSteps
    {
        [Given(@"felis nec Suspendisse molestie")]
        public void GivenInPulvinarCommodoDapibus()
        {
           AutomationStub.DoStep();
        }

        [When(@"tempus molestie ipsum massa")]
        public void WhenAmetCurabiturTellusHendrerit()
        {
           AutomationStub.DoStep();
        }

        [Given(@"augue id tristique erat eget")]
        public void GivenTacitiHimenaeosPerTortor()
        {
           AutomationStub.DoStep();
        }

        [When(@"(\d+) justo Sed ""(.*)""")]
        public void WhenSemTristiqueLiberoAmet(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"id id neque tempor dapibus")]
        public void WhenLuctusProinMassaTempor()
        {
           AutomationStub.DoStep();
        }

        [When(@"lacinia dictum (\d+)")]
        public void WhenCurabiturDolorInViverra(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"""(.*)"" (\d+) at (\d+) suscipit")]
        public void ThenNecNonCursusAmet(string p0, int p1, int p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

        [Given(@"(\d+) eros felis at lorem")]
        public void GivenCursusSitPurusEnim(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

    }
}
