using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class NecErosSemperNostraSteps
    {
        [Then(@"Fusce ""(.*)"" sit")]
        public void ThenInDiamCondimentumLacinia(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"vitae suscipit Phasellus (\d+)")]
        public void ThenBlanditTinciduntMassaBlandit(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"est dictum Integer conubia")]
        public void WhenMassaOrciSemperLobortis()
        {
           AutomationStub.DoStep();
        }

        [When(@"nulla nec dui (\d+)")]
        public void WhenGravidaSemPerVitae(int p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
