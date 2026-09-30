using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class BlanditEtLiberoPretiumSteps
    {
        [Given(@"vitae Nam Curabitur mi viverra")]
        public void GivenPurusDictumScelerisqueBlandit()
        {
           AutomationStub.DoStep();
        }

        [When(@"sem porta id Suspendisse mi")]
        public void WhenNamRisusErosEgestas()
        {
           AutomationStub.DoStep();
        }

        [Then(@"""(.*)"" dui a")]
        public void ThenUtEuElitTristique(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"Sed orci Quisque In (\d+)")]
        public void ThenPhasellusVulputateSitMolestie(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"accumsan mollis vulputate mi pulvinar")]
        public void WhenPhasellusNullaPhasellusNec()
        {
           AutomationStub.DoStep();
        }

        [When(@"Maecenas felis (\d+)")]
        public void WhenMassaInceptosSodalesLectus(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

    }
}
