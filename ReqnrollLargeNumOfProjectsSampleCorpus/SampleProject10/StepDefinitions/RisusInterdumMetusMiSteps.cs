using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class RisusInterdumMetusMiSteps
    {
        [When(@"est dictum Integer conubia")]
        public void WhenDiamExLeoElementum()
        {
           AutomationStub.DoStep();
        }

        [Then(@"condimentum lacinia blandit")]
        public void ThenInMiBlanditVitae()
        {
           AutomationStub.DoStep();
        }

        [Then(@"venenatis amet id in")]
        public void ThenDuiACursusSuspendisse()
        {
           AutomationStub.DoStep();
        }

        [Then(@"(\d+) dolor fermentum vel tempus")]
        public void ThenViverraPhasellusUtEgestas(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"vel sed dolor vestibulum")]
        public void WhenLoremNullaEuElementum()
        {
           AutomationStub.DoStep();
        }

        [When(@"In ligula vitae")]
        public void WhenTemporAliquamABibendum()
        {
           AutomationStub.DoStep();
        }

    }
}
