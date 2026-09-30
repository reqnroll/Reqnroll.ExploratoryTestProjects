using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class ConsequatTortorAccumsanCommodoSteps
    {
        [Given(@"diam sapien Suspendisse ""(.*)"" justo")]
        public void GivenNisiPhasellusDiamMi(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"""(.*)"" at sem rhoncus nec")]
        public void WhenUrnaFaucibusDapibusInceptos(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"nec (\d+) ""(.*)""")]
        public void ThenDignissimAIpsumVenenatis(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"Sed orci Quisque In (\d+)")]
        public void ThenInTellusDapibusImperdiet(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"nec ac in orci quis")]
        public void WhenInEgetArcuSapien(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"blandit (\d+) libero")]
        public void ThenAliquetVitaeSapienSit(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"bibendum Phasellus tellus ante")]
        public void WhenErosLoremNecLeo(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"tortor himenaeos tristique faucibus congue")]
        public void ThenCursusLuctusQuamMassa()
        {
           AutomationStub.DoStep();
        }

    }
}
