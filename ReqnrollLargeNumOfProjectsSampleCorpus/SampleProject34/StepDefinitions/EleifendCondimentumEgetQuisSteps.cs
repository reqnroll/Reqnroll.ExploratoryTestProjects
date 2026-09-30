using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class EleifendCondimentumEgetQuisSteps
    {
        [Given(@"condimentum commodo nec iaculis")]
        public void GivenFusceDuiNonTincidunt()
        {
           AutomationStub.DoStep();
        }

        [Then(@"vitae suscipit Phasellus (\d+)")]
        public void ThenHimenaeosAmetScelerisqueDapibus(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"in elementum ""(.*)""")]
        public void WhenPorttitorPhasellusAtTortor(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"id nulla (\d+)")]
        public void GivenEratDonecDiamPer(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"Lorem eget leo (\d+) Donec")]
        public void WhenAliquetInMiIn(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"sollicitudin varius cursus")]
        public void GivenAtVestibulumLitoraSapien()
        {
           AutomationStub.DoStep();
        }

    }
}
