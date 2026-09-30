using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class NequeFinibusSedAmetSteps
    {
        [Given(@"Donec eleifend condimentum")]
        public void GivenVitaeAtDapibusPorta()
        {
           AutomationStub.DoStep();
        }

        [When(@"malesuada vehicula eros tortor")]
        public void WhenSedSociosquAptentEros()
        {
           AutomationStub.DoStep();
        }

        [Then(@"nec (\d+) ""(.*)""")]
        public void ThenNecPraesentInterdumFusce(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"amet molestie vulputate")]
        public void GivenVenenatisMolestieUllamcorperViverra()
        {
           AutomationStub.DoStep();
        }

        [Given(@"nostra iaculis tempus egestas")]
        public void GivenSedSedVehiculaNunc()
        {
           AutomationStub.DoStep();
        }

        [Given(@"taciti mollis blandit egestas eu")]
        public void GivenElementumMassaVelBibendum(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
