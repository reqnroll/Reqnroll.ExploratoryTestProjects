using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class NecInSitSapienSteps
    {
        [Given(@"luctus urna (\d+) condimentum ""(.*)""")]
        public void GivenSuscipitSemDiamInteger(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"Lorem eleifend volutpat Ut urna")]
        public void WhenDictumMolestieCurabiturDignissim()
        {
           AutomationStub.DoStep();
        }

        [When(@"adipiscing massa molestie")]
        public void WhenAugueLigulaCommodoUt()
        {
           AutomationStub.DoStep();
        }

        [When(@"sapien quis (\d+) ""(.*)"" eros")]
        public void WhenNecAuctorConsequatNon(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"""(.*)"" efficitur ut")]
        public void ThenFaucibusEstNullaAt(string p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"libero Vestibulum eleifend elit")]
        public void ThenMolestieNonNecVitae()
        {
           AutomationStub.DoStep();
        }

    }
}
