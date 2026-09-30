using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class TempusDonecIdLiberoSteps
    {
        [Then(@"leo nulla litora")]
        public void ThenNecNuncDapibusJusto()
        {
           AutomationStub.DoStep();
        }

        [When(@"libero sollicitudin (\d+) pulvinar")]
        public void WhenEuEuHimenaeosPraesent(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"Suspendisse ""(.*)"" congue ""(.*)""")]
        public void WhenEtAtQuisqueIn(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"ultricies augue erat eu eget")]
        public void GivenBibendumVestibulumVitaeRisus()
        {
           AutomationStub.DoStep();
        }

        [When(@"venenatis id laoreet ""(.*)"" venenatis")]
        public void WhenOrciEtBibendumPorta(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"ad finibus augue")]
        public void ThenANuncCommodoPorta()
        {
           AutomationStub.DoStep();
        }

    }
}
