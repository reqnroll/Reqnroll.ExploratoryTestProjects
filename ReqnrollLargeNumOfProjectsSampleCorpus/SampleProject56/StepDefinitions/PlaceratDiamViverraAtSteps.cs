using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class PlaceratDiamViverraAtSteps
    {
        [Then(@"tellus taciti Aliquam nunc (\d+)")]
        public void ThenVestibulumMolestieNecIn(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"""(.*)"" dui a")]
        public void ThenFermentumOrciInCondimentum(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"(\d+) eros felis at lorem")]
        public void GivenLigulaPellentesqueDonecAmet(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"taciti mollis blandit egestas eu")]
        public void GivenPellentesqueInVitaeTincidunt(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"""(.*)"" fermentum vulputate sagittis lobortis")]
        public void GivenNonFermentumLobortisSed(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"id id neque tempor dapibus")]
        public void WhenMattisTemporPulvinarSit()
        {
           AutomationStub.DoStep();
        }

    }
}
