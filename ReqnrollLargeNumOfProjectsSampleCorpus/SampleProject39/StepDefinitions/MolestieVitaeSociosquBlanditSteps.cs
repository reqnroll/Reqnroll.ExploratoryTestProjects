using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class MolestieVitaeSociosquBlanditSteps
    {
        [Then(@"""(.*)"" eu quis per lobortis")]
        public void ThenErosLiberoSagittisViverra(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"""(.*)"" dui a")]
        public void ThenNequeTortorTorquentNec(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"egestas porta tortor")]
        public void GivenAliquamDignissimElitCommodo(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"(\d+) dignissim ""(.*)""")]
        public void ThenDuiVenenatisLaciniaDolor(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"commodo et conubia")]
        public void WhenLoremVestibulumEfficiturTincidunt()
        {
           AutomationStub.DoStep();
        }

        [When(@"egestas efficitur tellus")]
        public void WhenIaculisEgetTristiqueA()
        {
           AutomationStub.DoStep();
        }

        [Then(@"nec (\d+) ""(.*)""")]
        public void ThenErosTortorTacitiVel(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"id nulla (\d+)")]
        public void GivenLobortisAtPorttitorErat(int p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
