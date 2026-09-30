using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class AnteVulputateSitCongueSteps
    {
        [When(@"""(.*)"" at sem rhoncus nec")]
        public void WhenTorquentSuspendisseJustoFermentum(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"augue et sapien sem laoreet")]
        public void GivenMaecenasQuisAccumsanPer()
        {
           AutomationStub.DoStep();
        }

        [Then(@"in ""(.*)"" in")]
        public void ThenPortaAdipiscingDapibusAnte(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"(\d+) risus augue")]
        public void ThenIaculisErosDuiNisi(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"nulla ""(.*)"" euismod sit (\d+)")]
        public void ThenRisusDuisPhasellusEt(string p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"accumsan (\d+) Class")]
        public void GivenIdCurabiturDonecEt(int p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
