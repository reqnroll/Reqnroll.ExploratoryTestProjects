using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class TellusVelRisusMagnaSteps
    {
        [Given(@"id nulla (\d+)")]
        public void GivenLaciniaAnteSitNec(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"ante libero ut")]
        public void ThenVulputateEleifendBlanditHimenaeos()
        {
           AutomationStub.DoStep();
        }

        [When(@"Lorem eget leo (\d+) Donec")]
        public void WhenEuElementumDictumAuctor(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"in elementum ""(.*)""")]
        public void WhenMaurisQuisqueNecVulputate(string p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
