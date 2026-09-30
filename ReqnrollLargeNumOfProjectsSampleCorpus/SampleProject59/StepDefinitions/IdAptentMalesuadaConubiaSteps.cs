using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class IdAptentMalesuadaConubiaSteps
    {
        [Given(@"vitae Nam Curabitur mi viverra")]
        public void GivenAmetEtSedAuctor()
        {
           AutomationStub.DoStep();
        }

        [When(@"eleifend (\d+) blandit ""(.*)"" Aliquam")]
        public void WhenVitaeTemporMaecenasSem(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"tortor lacinia In eleifend")]
        public void WhenNecUtDonecDui()
        {
           AutomationStub.DoStep();
        }

        [Then(@"Ut ""(.*)"" (\d+) Class et")]
        public void ThenSitElementumRisusProin(string p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"Curabitur Aliquam orci accumsan id")]
        public void ThenLectusUrnaScelerisqueLuctus()
        {
           AutomationStub.DoStep();
        }

        [Given(@"dictum vulputate lectus consequat")]
        public void GivenFermentumFinibusLuctusIpsum()
        {
           AutomationStub.DoStep();
        }

        [Then(@"cursus tincidunt (\d+) (\d+) Morbi")]
        public void ThenQuisqueNecDictumDolor(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"lacinia dictum (\d+)")]
        public void WhenVitaePhasellusViverraEu(int p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
