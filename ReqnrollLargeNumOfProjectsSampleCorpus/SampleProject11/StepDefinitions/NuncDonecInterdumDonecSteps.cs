using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class NuncDonecInterdumDonecSteps
    {
        [Then(@"""(.*)"" eu quis per lobortis")]
        public void ThenInAtMaecenasLectus(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"molestie a a (\d+) pulvinar")]
        public void WhenTempusDonecMassaVel(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"tristique risus ""(.*)"" placerat inceptos")]
        public void GivenEuEuLobortisLigula(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"id id neque tempor dapibus")]
        public void WhenEuismodPortaExQuis()
        {
           AutomationStub.DoStep();
        }

        [Then(@"(\d+) himenaeos ""(.*)""")]
        public void ThenAugueVitaeQuisqueQuisque(int p0, string p1, Table p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

        [Then(@"pharetra elit ""(.*)"" Maecenas")]
        public void ThenMagnaTemporVelEx(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"augue risus ""(.*)"" amet")]
        public void ThenBlanditDonecMassaScelerisque(string p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"id nulla (\d+)")]
        public void GivenNonLaciniaScelerisqueConsectetur(int p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
