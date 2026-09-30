using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class EratUtMattisCurabiturSteps
    {
        [Given(@"dapibus amet iaculis condimentum non")]
        public void GivenJustoEgetIntegerInceptos()
        {
           AutomationStub.DoStep();
        }

        [Then(@"ad finibus augue")]
        public void ThenMiTemporNullaEget()
        {
           AutomationStub.DoStep();
        }

        [Then(@"In at conubia porta")]
        public void ThenSapienLaoreetSapienBlandit(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"tempus bibendum ultricies dictum")]
        public void GivenVelHendreritAcEfficitur(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"(\d+) eros felis at lorem")]
        public void GivenUtCommodoFelisViverra(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"egestas efficitur tellus")]
        public void WhenDiamQuisqueMattisSuspendisse()
        {
           AutomationStub.DoStep();
        }

    }
}
