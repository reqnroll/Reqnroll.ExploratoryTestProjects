using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class CurabiturCondimentumDuisUtSteps
    {
        [Then(@"(\d+) at Quisque dapibus ex")]
        public void ThenScelerisqueAuctorAnteConsequat(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"(\d+) felis quis dui")]
        public void GivenMetusAliquamJustoNulla(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"purus In Quisque")]
        public void ThenDiamAmetMolestieEx(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"tortor himenaeos tristique faucibus congue")]
        public void ThenLuctusLigulaImperdietLeo()
        {
           AutomationStub.DoStep();
        }

        [When(@"vitae efficitur (\d+) scelerisque")]
        public void WhenMagnaVelSitInteger(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"eleifend id nulla")]
        public void ThenDiamPhasellusNonVestibulum()
        {
           AutomationStub.DoStep();
        }

    }
}
