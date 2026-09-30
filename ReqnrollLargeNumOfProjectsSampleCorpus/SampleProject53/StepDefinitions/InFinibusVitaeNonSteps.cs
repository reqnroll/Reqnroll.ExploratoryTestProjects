using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class InFinibusVitaeNonSteps
    {
        [Given(@"sagittis eros scelerisque")]
        public void GivenAtDignissimInCurabitur()
        {
           AutomationStub.DoStep();
        }

        [Then(@"""(.*)"" molestie quis")]
        public void ThenEtMassaAmetSed(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"vitae orci tellus")]
        public void ThenAcIaculisPhasellusEleifend()
        {
           AutomationStub.DoStep();
        }

        [When(@"tortor lacinia In eleifend")]
        public void WhenVitaeTellusEtTempor()
        {
           AutomationStub.DoStep();
        }

        [When(@"""(.*)"" porta ""(.*)"" (\d+)")]
        public void WhenIaculisConubiaFelisDapibus(string p0, string p1, int p2, Table p3)
        {
           AutomationStub.DoStep(p0, p1, p2, p3);
        }

        [Then(@"auctor sit (\d+) congue")]
        public void ThenCommodoPulvinarTellusEgestas(int p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
