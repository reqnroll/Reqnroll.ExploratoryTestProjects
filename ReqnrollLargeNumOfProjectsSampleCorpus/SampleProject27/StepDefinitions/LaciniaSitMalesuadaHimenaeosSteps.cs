using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class LaciniaSitMalesuadaHimenaeosSteps
    {
        [Then(@"ipsum sapien lorem")]
        public void ThenImperdietPerAdMi()
        {
           AutomationStub.DoStep();
        }

        [Then(@"quis felis nunc")]
        public void ThenEgetInAdDapibus()
        {
           AutomationStub.DoStep();
        }

        [When(@"sit Suspendisse pretium")]
        public void WhenNuncQuisqueTortorDiam()
        {
           AutomationStub.DoStep();
        }

        [Then(@"justo sed volutpat id ""(.*)""")]
        public void ThenLuctusTempusElitEros(string p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"""(.*)"" tellus ""(.*)"" (\d+)")]
        public void WhenEgestasSedDuiJusto(string p0, string p1, int p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

        [When(@"commodo et conubia")]
        public void WhenRisusConsequatLectusDapibus()
        {
           AutomationStub.DoStep();
        }

        [Then(@"ante libero ut")]
        public void ThenNamNecTemporEst()
        {
           AutomationStub.DoStep();
        }

        [Then(@"(\d+) lacus porta scelerisque")]
        public void ThenCondimentumEuLigulaFeugiat(int p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
