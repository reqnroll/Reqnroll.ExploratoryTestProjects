using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class SapienSitIdNecSteps
    {
        [Then(@"(\d+) (\d+) Donec auctor Class")]
        public void ThenAtLigulaErosAt(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"Lorem eleifend volutpat Ut urna")]
        public void WhenCongueMollisInMassa()
        {
           AutomationStub.DoStep();
        }

        [When(@"lacinia dictum (\d+)")]
        public void WhenDiamDuiAugueAugue(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"mauris vel ""(.*)"" felis")]
        public void GivenLaoreetNullaSitEuismod(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"Fusce ""(.*)"" sit")]
        public void ThenSitErosLiberoAugue(string p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
