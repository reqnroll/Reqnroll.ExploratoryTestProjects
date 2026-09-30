using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class MollisEtRhoncusFermentumSteps
    {
        [Then(@"amet ""(.*)"" in vitae tincidunt")]
        public void ThenCondimentumEfficiturLobortisRisus(string p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"""(.*)"" vitae enim")]
        public void ThenVehiculaLigulaTristiquePorta(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"blandit sagittis eleifend taciti (\d+)")]
        public void WhenMagnaQuisqueNonMolestie(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"venenatis egestas nec in")]
        public void GivenEstInConubiaAmet()
        {
           AutomationStub.DoStep();
        }

        [Given(@"(\d+) id sodales erat")]
        public void GivenVulputateQuisqueLiberoPhasellus(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"in In id")]
        public void ThenEuAPretiumElementum(string p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
