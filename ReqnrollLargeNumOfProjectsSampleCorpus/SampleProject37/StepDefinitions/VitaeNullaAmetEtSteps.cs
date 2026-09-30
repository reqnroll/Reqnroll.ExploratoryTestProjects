using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class VitaeNullaAmetEtSteps
    {
        [Then(@"ac orci blandit")]
        public void ThenDiamNecTempusEleifend()
        {
           AutomationStub.DoStep();
        }

        [Given(@"condimentum commodo nec iaculis")]
        public void GivenDuiBibendumDuiLaoreet()
        {
           AutomationStub.DoStep();
        }

        [Given(@"id nulla (\d+)")]
        public void GivenUrnaAliquetScelerisqueA(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"vitae eleifend vel ""(.*)"" dolor")]
        public void GivenNisiSapienDapibusSuspendisse(string p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"(\d+) luctus (\d+) in")]
        public void ThenNullaNullaJustoAccumsan(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"in elementum ""(.*)""")]
        public void WhenRisusDuiLectusTempus(string p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
