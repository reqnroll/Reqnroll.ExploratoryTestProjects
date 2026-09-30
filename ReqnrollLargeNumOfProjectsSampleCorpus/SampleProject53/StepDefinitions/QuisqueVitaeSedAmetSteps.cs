using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class QuisqueVitaeSedAmetSteps
    {
        [When(@"""(.*)"" sed ""(.*)""")]
        public void WhenAugueVelRhoncusDapibus(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"in dignissim tempor massa")]
        public void WhenSapienMattisAmetArcu()
        {
           AutomationStub.DoStep();
        }

        [Then(@"Curabitur Aliquam orci accumsan id")]
        public void ThenSitIaculisEuismodSit()
        {
           AutomationStub.DoStep();
        }

        [Then(@"nec ""(.*)"" (\d+)")]
        public void ThenSuspendisseLigulaVitaePurus(string p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"In at conubia porta")]
        public void ThenAmetAVenenatisNisi(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"tellus lorem (\d+) scelerisque")]
        public void GivenPhasellusErosQuisqueAliquam(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

    }
}
