using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class SitCurabiturUrnaNostraSteps
    {
        [When(@"Lorem eget leo (\d+) Donec")]
        public void WhenErosMolestieInceptosNec(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"viverra feugiat aptent vulputate non")]
        public void WhenProinInEuUrna()
        {
           AutomationStub.DoStep();
        }

        [When(@"molestie pellentesque ""(.*)"" est")]
        public void WhenElitMassaLitoraSagittis(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"sapien vitae ""(.*)"" ""(.*)"" molestie")]
        public void WhenLitoraAliquetANulla(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"enim et eu")]
        public void GivenLobortisEtPorttitorHimenaeos()
        {
           AutomationStub.DoStep();
        }

        [Then(@"(\d+) himenaeos ""(.*)""")]
        public void ThenMassaDonecNuncPharetra(int p0, string p1, Table p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

    }
}
