using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class AugueTempusSitInceptosSteps
    {
        [Then(@"vitae Aliquam Nam commodo")]
        public void ThenErosScelerisqueMagnaAugue()
        {
           AutomationStub.DoStep();
        }

        [When(@"est dictum Integer conubia")]
        public void WhenAccumsanMagnaMiA()
        {
           AutomationStub.DoStep();
        }

        [When(@"urna molestie purus blandit")]
        public void WhenOdioRisusPortaFelis()
        {
           AutomationStub.DoStep();
        }

        [Then(@"""(.*)"" amet (\d+) non Nam")]
        public void ThenPulvinarViverraMetusSuspendisse(string p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"massa justo lectus pretium Praesent")]
        public void GivenNecMagnaDonecIn()
        {
           AutomationStub.DoStep();
        }

        [When(@"a non dictum")]
        public void WhenMagnaEtElementumPhasellus()
        {
           AutomationStub.DoStep();
        }

    }
}
