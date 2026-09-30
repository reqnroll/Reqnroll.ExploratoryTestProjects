using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class ClassUltriciesSedSitSteps
    {
        [When(@"per mi efficitur Nulla")]
        public void WhenFusceAcNullaLacus(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"commodo et conubia")]
        public void WhenSemLoremCongueQuis()
        {
           AutomationStub.DoStep();
        }

        [Given(@"vitae Nam Curabitur mi viverra")]
        public void GivenMetusNecAdFinibus()
        {
           AutomationStub.DoStep();
        }

        [Given(@"mauris vel ""(.*)"" felis")]
        public void GivenAugueQuisEnimSed(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"id id neque tempor dapibus")]
        public void WhenUtLoremLoremFinibus()
        {
           AutomationStub.DoStep();
        }

        [Then(@"lorem dictum (\d+) accumsan")]
        public void ThenMolestieFelisTinciduntSuspendisse(int p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
