using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class LiberoEfficiturTacitiVitaeSteps
    {
        [Given(@"libero a placerat ""(.*)"" viverra")]
        public void GivenLeoTortorDiamNostra(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"""(.*)"" vitae Cras")]
        public void GivenEtDuiMolestieErat(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"libero non cursus ""(.*)""")]
        public void ThenRisusVelLectusRhoncus(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"ligula ""(.*)"" scelerisque augue")]
        public void WhenElementumLobortisSuspendisseOrci(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"a augue id commodo egestas")]
        public void WhenAnteAmetSedSem()
        {
           AutomationStub.DoStep();
        }

        [Given(@"amet dui vulputate orci")]
        public void GivenMolestiePharetraLoremLigula()
        {
           AutomationStub.DoStep();
        }

    }
}
