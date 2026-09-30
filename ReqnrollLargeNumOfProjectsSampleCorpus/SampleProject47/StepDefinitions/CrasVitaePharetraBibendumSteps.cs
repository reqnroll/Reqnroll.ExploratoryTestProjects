using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class CrasVitaePharetraBibendumSteps
    {
        [Given(@"mauris vel ""(.*)"" felis")]
        public void GivenCrasMalesuadaUltriciesEgestas(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"lorem dictum (\d+) accumsan")]
        public void ThenHimenaeosIaculisVulputateSociosqu(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"per mi efficitur Nulla")]
        public void WhenLigulaLitoraAnteLorem(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"tempus bibendum ultricies dictum")]
        public void GivenTacitiIpsumVolutpatSit(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"in elementum ""(.*)""")]
        public void WhenAliquetMiLitoraInceptos(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"adipiscing massa molestie")]
        public void WhenNuncTortorVulputateAmet()
        {
           AutomationStub.DoStep();
        }

        [When(@"libero in sit suscipit diam")]
        public void WhenDapibusNamAuctorVel()
        {
           AutomationStub.DoStep();
        }

        [Then(@"ipsum sapien lorem")]
        public void ThenTacitiCondimentumNisiPretium()
        {
           AutomationStub.DoStep();
        }

    }
}
