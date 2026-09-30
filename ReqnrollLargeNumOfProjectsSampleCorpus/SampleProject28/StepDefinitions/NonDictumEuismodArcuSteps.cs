using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class NonDictumEuismodArcuSteps
    {
        [When(@"egestas efficitur tellus")]
        public void WhenRisusAugueIntegerSit()
        {
           AutomationStub.DoStep();
        }

        [When(@"adipiscing massa molestie")]
        public void WhenElementumDictumInFeugiat()
        {
           AutomationStub.DoStep();
        }

        [Then(@"(\d+) dolor fermentum vel tempus")]
        public void ThenIpsumLectusNecAt(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"condimentum commodo nec iaculis")]
        public void GivenMassaMolestieVelSuspendisse()
        {
           AutomationStub.DoStep();
        }

        [When(@"In ligula vitae")]
        public void WhenPortaEgestasNecMolestie()
        {
           AutomationStub.DoStep();
        }

        [When(@"in elementum ""(.*)""")]
        public void WhenSapienTempusSodalesUt(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"nunc augue felis cursus")]
        public void GivenEuEnimClassEt(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"tellus taciti Aliquam nunc (\d+)")]
        public void ThenEnimDuisSociosquPurus(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"venenatis amet id in")]
        public void ThenPellentesqueInScelerisqueVitae()
        {
           AutomationStub.DoStep();
        }

        [Given(@"""(.*)"" vitae Cras")]
        public void GivenAnteAptentTortorMassa(string p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
