using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class DonecEleifendInInceptosSteps
    {
        [Given(@"porta orci nulla (\d+) risus")]
        public void GivenAliquamLiberoVehiculaAugue(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"""(.*)"" amet in congue")]
        public void ThenIntegerPortaNequeMalesuada(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"conubia viverra in in")]
        public void ThenJustoMolestieDapibusAmet()
        {
           AutomationStub.DoStep();
        }

        [Then(@"vitae Maecenas non dictum purus")]
        public void ThenPhasellusVitaeSapienIn()
        {
           AutomationStub.DoStep();
        }

        [When(@"(\d+) ad Sed")]
        public void WhenUrnaNullaNamDiam(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"ad id luctus bibendum Suspendisse")]
        public void ThenIntegerIpsumEuismodNulla()
        {
           AutomationStub.DoStep();
        }

        [When(@"(\d+) justo Sed ""(.*)""")]
        public void WhenNecPhasellusSollicitudinAccumsan(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"(\d+) dignissim ""(.*)""")]
        public void ThenDignissimPellentesqueLoremMollis(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

    }
}
