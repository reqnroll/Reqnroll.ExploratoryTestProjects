using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class MaurisEgetPerEgestasSteps
    {
        [Given(@"risus ultricies ac")]
        public void GivenTristiqueRisusUllamcorperPlacerat()
        {
           AutomationStub.DoStep();
        }

        [Given(@"id nulla (\d+)")]
        public void GivenInceptosVelMassaCondimentum(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"quis ipsum erat")]
        public void WhenIpsumOrciPellentesqueEget()
        {
           AutomationStub.DoStep();
        }

        [Given(@"sem per vitae")]
        public void GivenPurusNuncPretiumSit()
        {
           AutomationStub.DoStep();
        }

        [Given(@"vitae Nam Curabitur mi viverra")]
        public void GivenVestibulumFelisEuAnte()
        {
           AutomationStub.DoStep();
        }

        [When(@"nulla nec dui (\d+)")]
        public void WhenPurusTacitiEtSagittis(int p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
