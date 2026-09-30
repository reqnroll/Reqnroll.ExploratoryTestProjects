using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class NullaImperdietSitNibhSteps
    {
        [When(@"nulla nec dui (\d+)")]
        public void WhenCongueEuCurabiturSem(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"vitae Maecenas non dictum purus")]
        public void ThenInAmetMolestieVulputate()
        {
           AutomationStub.DoStep();
        }

        [Then(@"lorem dictum (\d+) accumsan")]
        public void ThenTristiqueQuisDapibusVenenatis(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"massa justo lectus pretium Praesent")]
        public void GivenNostraUllamcorperTortorIn()
        {
           AutomationStub.DoStep();
        }

        [Given(@"""(.*)"" eu id nec")]
        public void GivenAugueAmetMolestieEget(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"libero in sit suscipit diam")]
        public void WhenInQuisqueAtIn()
        {
           AutomationStub.DoStep();
        }

    }
}
