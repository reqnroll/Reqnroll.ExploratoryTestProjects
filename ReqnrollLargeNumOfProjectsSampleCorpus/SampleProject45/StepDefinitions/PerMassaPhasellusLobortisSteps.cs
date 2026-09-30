using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class PerMassaPhasellusLobortisSteps
    {
        [Given(@"nulla dapibus feugiat Aliquam Nulla")]
        public void GivenNonLigulaElementumCondimentum(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"nec scelerisque porta (\d+) iaculis")]
        public void ThenEuismodInceptosInAmet(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"""(.*)"" (\d+) laoreet")]
        public void ThenEfficiturViverraAtTristique(string p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"nec (\d+) massa molestie")]
        public void WhenMorbiSitVitaeVestibulum(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"""(.*)"" amet in congue")]
        public void ThenEtInterdumConsequatTortor(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"augue id tristique erat eget")]
        public void GivenNonEtLaciniaA()
        {
           AutomationStub.DoStep();
        }

    }
}
