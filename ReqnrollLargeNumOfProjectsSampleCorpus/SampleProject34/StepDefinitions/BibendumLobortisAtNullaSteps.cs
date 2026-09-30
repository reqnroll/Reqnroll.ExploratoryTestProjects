using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class BibendumLobortisAtNullaSteps
    {
        [Given(@"felis tincidunt Suspendisse congue")]
        public void GivenSitEfficiturSuspendisseSociosqu()
        {
           AutomationStub.DoStep();
        }

        [When(@"a (\d+) Phasellus amet")]
        public void WhenSapienLeoFelisNec(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"faucibus ligula (\d+) porta")]
        public void ThenLiberoLaoreetMassaFelis(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"(\d+) molestie odio (\d+) dolor")]
        public void GivenIpsumEratEleifendVulputate(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"laoreet ""(.*)"" hendrerit non mi")]
        public void WhenErosIdMetusAliquam(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"vitae orci tellus")]
        public void ThenEuismodPellentesqueVulputateDonec()
        {
           AutomationStub.DoStep();
        }

    }
}
