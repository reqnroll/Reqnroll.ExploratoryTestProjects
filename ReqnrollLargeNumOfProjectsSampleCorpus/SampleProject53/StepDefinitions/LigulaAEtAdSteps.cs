using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class LigulaAEtAdSteps
    {
        [Then(@"blandit (\d+) libero")]
        public void ThenVitaeMolestieJustoEx(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"condimentum fermentum (\d+)")]
        public void WhenAmetNuncAtArcu(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"mauris vel ""(.*)"" felis")]
        public void GivenPraesentNonFermentumLectus(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"scelerisque risus egestas Quisque orci")]
        public void GivenConubiaPortaScelerisqueVulputate()
        {
           AutomationStub.DoStep();
        }

        [When(@"in (\d+) nulla leo")]
        public void WhenPharetraVitaeViverraMolestie(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"interdum blandit a")]
        public void GivenRisusErosNullaProin()
        {
           AutomationStub.DoStep();
        }

    }
}
