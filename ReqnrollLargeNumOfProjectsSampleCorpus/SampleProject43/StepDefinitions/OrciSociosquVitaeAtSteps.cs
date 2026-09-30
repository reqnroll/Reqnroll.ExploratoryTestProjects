using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class OrciSociosquVitaeAtSteps
    {
        [Then(@"(\d+) justo ""(.*)""")]
        public void ThenIntegerPhasellusClassEst(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"felis nec Suspendisse molestie")]
        public void GivenAnteTacitiQuisqueTortor()
        {
           AutomationStub.DoStep();
        }

        [When(@"venenatis augue diam magna (\d+)")]
        public void WhenBibendumDignissimDolorNec(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"laoreet ""(.*)"" hendrerit non mi")]
        public void WhenDiamSedEfficiturInceptos(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"molestie pellentesque ""(.*)"" est")]
        public void WhenSitVenenatisEleifendNostra(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"(\d+) at Quisque dapibus ex")]
        public void ThenElitSitANulla(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"orci eu augue (\d+)")]
        public void GivenUrnaPortaPortaLacus(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"laoreet ""(.*)"" Quisque lobortis blandit")]
        public void GivenSemperInVehiculaJusto(string p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
