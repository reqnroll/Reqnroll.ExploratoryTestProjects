using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class BlanditEgetTempusIpsumSteps
    {
        [Then(@"ad id luctus bibendum Suspendisse")]
        public void ThenIdConubiaBlanditCommodo()
        {
           AutomationStub.DoStep();
        }

        [Given(@"(\d+) (\d+) malesuada ""(.*)"" ultricies")]
        public void GivenSuspendisseLuctusDolorVel(int p0, int p1, string p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

        [When(@"eleifend (\d+) blandit ""(.*)"" Aliquam")]
        public void WhenDuiCondimentumFeugiatLectus(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"mauris eu Sed")]
        public void ThenAmetTempusElementumDolor(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"faucibus ligula (\d+) porta")]
        public void ThenAtUrnaSociosquPretium(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"sed lectus nec blandit")]
        public void GivenAmetAAuctorElementum(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
