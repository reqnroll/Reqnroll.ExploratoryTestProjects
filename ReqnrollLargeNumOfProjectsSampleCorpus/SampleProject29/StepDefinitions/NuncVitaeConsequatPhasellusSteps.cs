using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class NuncVitaeConsequatPhasellusSteps
    {
        [Then(@"in in In sem")]
        public void ThenSedEtQuisEt()
        {
           AutomationStub.DoStep();
        }

        [Then(@"mollis in per")]
        public void ThenVitaeCursusSitLitora()
        {
           AutomationStub.DoStep();
        }

        [Then(@"ante libero ut")]
        public void ThenAmetMetusElementumEros()
        {
           AutomationStub.DoStep();
        }

        [Then(@"(\d+) laoreet ""(.*)""")]
        public void ThenPhasellusNecNuncEu(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"commodo eget magna molestie")]
        public void WhenMiInErosNec(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"eu porta conubia ""(.*)""")]
        public void ThenLaciniaSapienSuspendisseLaoreet(string p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
