using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class MiFelisEtConsequatSteps
    {
        [Then(@"ex dignissim elementum")]
        public void ThenMolestieAtDignissimSapien()
        {
           AutomationStub.DoStep();
        }

        [Given(@"tempus bibendum ultricies dictum")]
        public void GivenInCommodoDuiEx(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"(\d+) nisi odio ""(.*)""")]
        public void WhenIdMolestieViverraMalesuada(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"dolor (\d+) ""(.*)"" in")]
        public void GivenLobortisVolutpatAliquamSed(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"libero in sit suscipit diam")]
        public void WhenNisiMaecenasRisusPellentesque()
        {
           AutomationStub.DoStep();
        }

        [When(@"sodales Morbi hendrerit")]
        public void WhenUrnaVitaeExDuis()
        {
           AutomationStub.DoStep();
        }

    }
}
