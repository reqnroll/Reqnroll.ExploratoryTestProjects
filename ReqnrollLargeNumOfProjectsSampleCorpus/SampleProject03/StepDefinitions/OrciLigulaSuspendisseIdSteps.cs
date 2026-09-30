using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class OrciLigulaSuspendisseIdSteps
    {
        [Then(@"(\d+) dolor fermentum vel tempus")]
        public void ThenVitaeSagittisNecDiam(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"in (\d+) nulla leo")]
        public void WhenRisusNecDuisIn(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"libero in sit suscipit diam")]
        public void WhenAugueFelisUltriciesCongue()
        {
           AutomationStub.DoStep();
        }

        [Then(@"libero dignissim elementum varius tempor")]
        public void ThenSapienPulvinarAliquamDuis()
        {
           AutomationStub.DoStep();
        }

        [Then(@"a mi ""(.*)""")]
        public void ThenAdNequeOrciAmet(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"vel (\d+) (\d+)")]
        public void GivenAtNuncErosNulla(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"commodo eget magna molestie")]
        public void WhenConsequatDapibusEgetMolestie(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"ligula eu commodo justo")]
        public void GivenEgetNonMalesuadaArcu(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
