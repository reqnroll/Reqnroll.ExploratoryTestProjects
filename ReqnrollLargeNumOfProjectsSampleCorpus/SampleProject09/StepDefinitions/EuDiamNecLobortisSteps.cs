using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class EuDiamNecLobortisSteps
    {
        [Then(@"lorem dictum (\d+) accumsan")]
        public void ThenOdioQuisqueVitaeFelis(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"id nulla (\d+)")]
        public void GivenAliquamAnteAtMalesuada(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"nec scelerisque porta (\d+) iaculis")]
        public void ThenSuscipitAliquamEuPhasellus(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"in elementum ""(.*)""")]
        public void WhenMiEgetEuEu(string p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
