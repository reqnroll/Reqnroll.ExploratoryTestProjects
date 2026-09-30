using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class NisiAcPurusUrnaSteps
    {
        [Then(@"ante sapien nec")]
        public void ThenDictumNecAEtiam()
        {
           AutomationStub.DoStep();
        }

        [Then(@"augue risus ""(.*)"" amet")]
        public void ThenSodalesAmetLaoreetTortor(string p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"Fusce ""(.*)"" sit")]
        public void ThenTemporDapibusLeoEt(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"vel sagittis risus")]
        public void GivenNullaSociosquQuisqueAt()
        {
           AutomationStub.DoStep();
        }

        [When(@"molestie a a (\d+) pulvinar")]
        public void WhenASedNecTempor(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"purus (\d+) (\d+) (\d+) nec")]
        public void WhenClassUtLoremConubia(int p0, int p1, int p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

    }
}
