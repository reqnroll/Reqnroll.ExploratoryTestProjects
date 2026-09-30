using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class MassaVestibulumPulvinarLaoreetSteps
    {
        [Given(@"nec scelerisque ""(.*)"" dictum ""(.*)""")]
        public void GivenAdVulputateLobortisNulla(string p0, string p1, Table p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

        [When(@"In ligula vitae")]
        public void WhenPurusAliquetDapibusNunc()
        {
           AutomationStub.DoStep();
        }

        [Then(@"(\d+) mattis Nunc Lorem vitae")]
        public void ThenLobortisUrnaCursusFelis(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"augue amet molestie")]
        public void WhenSuspendissePurusRisusEnim()
        {
           AutomationStub.DoStep();
        }

        [Given(@"non (\d+) volutpat Quisque")]
        public void GivenImperdietOdioSemCommodo(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"augue purus Donec augue")]
        public void GivenAuctorEgetPlaceratVehicula(string p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
