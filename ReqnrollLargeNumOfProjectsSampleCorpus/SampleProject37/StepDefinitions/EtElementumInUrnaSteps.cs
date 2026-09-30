using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class EtElementumInUrnaSteps
    {
        [Then(@"pharetra nostra auctor purus pharetra")]
        public void ThenSedAcEuDignissim()
        {
           AutomationStub.DoStep();
        }

        [Then(@"Nunc pulvinar Sed")]
        public void ThenVitaeAcLigulaVenenatis()
        {
           AutomationStub.DoStep();
        }

        [Then(@"Nulla (\d+) Suspendisse commodo ac")]
        public void ThenNonDiamMassaLitora(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"""(.*)"" pretium ""(.*)""")]
        public void WhenDonecEratFinibusConsectetur(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"pharetra elit ""(.*)"" Maecenas")]
        public void ThenVestibulumInLitoraDictum(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"dolor blandit vulputate eu")]
        public void WhenIdAntePulvinarMorbi()
        {
           AutomationStub.DoStep();
        }

    }
}
