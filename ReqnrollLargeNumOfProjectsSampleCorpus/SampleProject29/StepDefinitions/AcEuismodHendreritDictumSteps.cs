using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class AcEuismodHendreritDictumSteps
    {
        [Then(@"(\d+) ipsum elementum (\d+) Phasellus")]
        public void ThenIaculisAtTempusEgestas(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"""(.*)"" fermentum vulputate sagittis lobortis")]
        public void GivenLiberoLuctusPerPorta(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"elit Phasellus sollicitudin")]
        public void WhenSapienTristiqueInSapien()
        {
           AutomationStub.DoStep();
        }

        [When(@"commodo et conubia")]
        public void WhenSedInSagittisArcu()
        {
           AutomationStub.DoStep();
        }

        [Given(@"faucibus nisi egestas ligula sem")]
        public void GivenQuisEuismodFaucibusTempor()
        {
           AutomationStub.DoStep();
        }

        [Then(@"lobortis (\d+) augue")]
        public void ThenMolestieExSemTristique(int p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
