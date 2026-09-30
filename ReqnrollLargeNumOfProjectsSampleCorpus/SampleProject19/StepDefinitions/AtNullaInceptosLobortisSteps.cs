using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class AtNullaInceptosLobortisSteps
    {
        [When(@"a augue id commodo egestas")]
        public void WhenDignissimSedElementumA()
        {
           AutomationStub.DoStep();
        }

        [Then(@"scelerisque rhoncus lobortis (\d+)")]
        public void ThenVitaeSitAmetNostra(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"tellus taciti Aliquam nunc (\d+)")]
        public void ThenCongueVelVitaeJusto(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"venenatis amet id in")]
        public void ThenLigulaUltriciesTortorLibero()
        {
           AutomationStub.DoStep();
        }

        [Then(@"condimentum (\d+) ""(.*)""")]
        public void ThenNullaDuisPlaceratNulla(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"Integer ""(.*)"" Ut orci ""(.*)""")]
        public void GivenVestibulumFinibusEuOrci(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"urna molestie purus blandit")]
        public void WhenMolestieRisusAdipiscingLeo()
        {
           AutomationStub.DoStep();
        }

        [Then(@"eu porta conubia ""(.*)""")]
        public void ThenBlanditSitUtAmet(string p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
