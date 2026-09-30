using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class DuiConsequatBlanditLobortisSteps
    {
        [Given(@"nostra imperdiet vitae dignissim")]
        public void GivenTellusDuisAArcu()
        {
           AutomationStub.DoStep();
        }

        [Given(@"tortor et (\d+)")]
        public void GivenMiUltriciesMetusErat(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"egestas efficitur tellus")]
        public void WhenAliquetMalesuadaASodales()
        {
           AutomationStub.DoStep();
        }

        [When(@"non diam ""(.*)""")]
        public void WhenMassaNuncAuctorPorta(string p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"augue sodales commodo (\d+) amet")]
        public void WhenEgestasVitaeCurabiturMassa(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"Aliquam nibh imperdiet dignissim")]
        public void WhenDonecTellusNecLacinia()
        {
           AutomationStub.DoStep();
        }

    }
}
