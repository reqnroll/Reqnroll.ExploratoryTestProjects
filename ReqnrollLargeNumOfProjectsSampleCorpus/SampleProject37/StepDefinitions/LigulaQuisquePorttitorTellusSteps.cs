using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class LigulaQuisquePorttitorTellusSteps
    {
        [Then(@"justo sed volutpat id ""(.*)""")]
        public void ThenErosDuiMaecenasNulla(string p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"feugiat sodales risus")]
        public void WhenEgetEtElementumPraesent()
        {
           AutomationStub.DoStep();
        }

        [When(@"quis ipsum erat")]
        public void WhenEgetAmetUtConubia()
        {
           AutomationStub.DoStep();
        }

        [Given(@"(\d+) elit (\d+)")]
        public void GivenMolestieSemCurabiturConsectetur(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"ante (\d+) taciti (\d+)")]
        public void ThenScelerisqueEgestasSemperEtiam(int p0, int p1, string p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

        [When(@"vel sed dolor vestibulum")]
        public void WhenANonNecSapien()
        {
           AutomationStub.DoStep();
        }

    }
}
