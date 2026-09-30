using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class ExUtASodalesSteps
    {
        [When(@"(\d+) pulvinar at Integer ""(.*)""")]
        public void WhenLobortisAugueTacitiLacus(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"condimentum lacinia blandit")]
        public void ThenCondimentumInPhasellusEgestas()
        {
           AutomationStub.DoStep();
        }

        [When(@"sit Suspendisse pretium")]
        public void WhenDuisVitaeElementumEgestas()
        {
           AutomationStub.DoStep();
        }

        [Given(@"pharetra libero Maecenas")]
        public void GivenVitaeSemPretiumAmet()
        {
           AutomationStub.DoStep();
        }

        [Given(@"(\d+) eros felis at lorem")]
        public void GivenSedLaciniaIpsumLigula(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"scelerisque rhoncus lobortis (\d+)")]
        public void ThenEgestasNecUtInterdum(int p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
