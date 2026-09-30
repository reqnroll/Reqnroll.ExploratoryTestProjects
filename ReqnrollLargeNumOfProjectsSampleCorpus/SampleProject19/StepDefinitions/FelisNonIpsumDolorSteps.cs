using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class FelisNonIpsumDolorSteps
    {
        [When(@"(\d+) ut accumsan scelerisque lectus")]
        public void WhenEnimEgetNecTellus(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"condimentum commodo nec iaculis")]
        public void GivenEgestasDignissimOrciTorquent()
        {
           AutomationStub.DoStep();
        }

        [When(@"est dictum Integer conubia")]
        public void WhenFeugiatIpsumEgestasEu()
        {
           AutomationStub.DoStep();
        }

        [Given(@"nulla dapibus feugiat Aliquam Nulla")]
        public void GivenEnimLectusUtEfficitur(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"nostra molestie ut")]
        public void GivenVitaeAdNisiDonec()
        {
           AutomationStub.DoStep();
        }

        [Given(@"ante pellentesque varius")]
        public void GivenVitaeVehiculaLiberoId()
        {
           AutomationStub.DoStep();
        }

        [Then(@"nec scelerisque porta (\d+) iaculis")]
        public void ThenSedMolestieTinciduntAc(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"Nunc pulvinar Sed")]
        public void ThenCurabiturSuscipitScelerisqueVolutpat()
        {
           AutomationStub.DoStep();
        }

    }
}
