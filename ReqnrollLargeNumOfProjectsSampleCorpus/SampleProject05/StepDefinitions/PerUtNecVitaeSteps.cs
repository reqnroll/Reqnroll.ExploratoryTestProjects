using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class PerUtNecVitaeSteps
    {
        [Then(@"(\d+) dolor fermentum vel tempus")]
        public void ThenOdioUrnaImperdietSit(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"Nulla vitae iaculis ""(.*)""")]
        public void ThenMiSagittisTemporEt(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"id dignissim Suspendisse")]
        public void WhenAtCommodoCommodoVestibulum()
        {
           AutomationStub.DoStep();
        }

        [Given(@"Vestibulum efficitur tincidunt iaculis (\d+)")]
        public void GivenLitoraTortorPerEros(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"diam suscipit fermentum")]
        public void GivenNequeArcuSemMolestie()
        {
           AutomationStub.DoStep();
        }

        [When(@"pharetra et malesuada viverra")]
        public void WhenEtNecErosUt()
        {
           AutomationStub.DoStep();
        }

    }
}
