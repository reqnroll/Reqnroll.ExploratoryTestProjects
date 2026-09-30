using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class QuisqueAtInTellusSteps
    {
        [Then(@"finibus leo ""(.*)"" blandit")]
        public void ThenPulvinarNullaLeoNulla(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"ante libero ut")]
        public void ThenLitoraEuSitAmet()
        {
           AutomationStub.DoStep();
        }

        [When(@"commodo elit et eget Integer")]
        public void WhenVitaeEleifendFaucibusLitora()
        {
           AutomationStub.DoStep();
        }

        [Then(@"(\d+) (\d+) Donec auctor Class")]
        public void ThenUrnaIpsumVitaeIn(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"taciti mollis blandit egestas eu")]
        public void GivenVestibulumMiSociosquInteger(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"(\d+) ""(.*)"" conubia conubia mi")]
        public void GivenMalesuadaSedCondimentumCondimentum(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"""(.*)"" eu id nec")]
        public void GivenAtTemporSapienQuis(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"sed lectus nec blandit")]
        public void GivenNullaSedErosMauris(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
