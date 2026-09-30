using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class QuisqueNecFelisDapibusSteps
    {
        [Given(@"(\d+) pretium Phasellus")]
        public void GivenPerEuMiIaculis(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"adipiscing massa molestie")]
        public void WhenTellusElitLoremLobortis()
        {
           AutomationStub.DoStep();
        }

        [When(@"faucibus (\d+) sociosqu")]
        public void WhenPhasellusMorbiPraesentTristique(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"vel in diam")]
        public void WhenTacitiEratFelisClass()
        {
           AutomationStub.DoStep();
        }

        [Given(@"libero a placerat ""(.*)"" viverra")]
        public void GivenSemEuLitoraCursus(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"Lorem eleifend volutpat Ut urna")]
        public void WhenMiVitaeSodalesScelerisque()
        {
           AutomationStub.DoStep();
        }

        [Then(@"(\d+) ipsum elementum (\d+) Phasellus")]
        public void ThenMassaCurabiturNonLeo(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"egestas efficitur tellus")]
        public void WhenNisiErosLaoreetSuspendisse()
        {
           AutomationStub.DoStep();
        }

    }
}
