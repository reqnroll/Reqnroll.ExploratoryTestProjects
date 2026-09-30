using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class SuspendisseFermentumTemporEnimSteps
    {
        [Given(@"vestibulum arcu ""(.*)"" eget in")]
        public void GivenLigulaEratNonPhasellus(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"a laoreet vel")]
        public void ThenEgetPharetraQuisqueTorquent()
        {
           AutomationStub.DoStep();
        }

        [Given(@"risus eros molestie")]
        public void GivenSitSitConsecteturPraesent()
        {
           AutomationStub.DoStep();
        }

        [Given(@"""(.*)"" litora (\d+)")]
        public void GivenIpsumNullaLoremIn(string p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"dictum a in eu")]
        public void ThenBlanditVitaeNuncNulla()
        {
           AutomationStub.DoStep();
        }

        [Given(@"risus (\d+) (\d+)")]
        public void GivenInEtTinciduntUltricies(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

    }
}
