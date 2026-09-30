using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class PerPortaNonConubiaSteps
    {
        [When(@"(\d+) elit blandit pretium (\d+)")]
        public void WhenBibendumElementumVolutpatVenenatis(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"(\d+) eget Nulla ""(.*)""")]
        public void GivenLuctusDignissimAccumsanEget(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"urna (\d+) suscipit")]
        public void ThenVulputateNullaFaucibusDictum(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"(\d+) dignissim ""(.*)""")]
        public void ThenMiLuctusEfficiturJusto(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"risus ultricies ac")]
        public void GivenAuctorUltriciesRisusMolestie()
        {
           AutomationStub.DoStep();
        }

        [When(@"est vel leo")]
        public void WhenEtSedSuspendisseElit()
        {
           AutomationStub.DoStep();
        }

    }
}
