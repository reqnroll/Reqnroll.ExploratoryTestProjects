using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class MiLobortisEgestasElitSteps
    {
        [When(@"(\d+) justo Sed ""(.*)""")]
        public void WhenQuisqueLiberoSuspendisseLibero(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"commodo elit et eget Integer")]
        public void WhenAuctorRhoncusVolutpatVestibulum()
        {
           AutomationStub.DoStep();
        }

        [When(@"tempus molestie ipsum massa")]
        public void WhenConsequatExLobortisLibero()
        {
           AutomationStub.DoStep();
        }

        [When(@"porttitor porta elit in")]
        public void WhenAugueViverraSollicitudinUrna()
        {
           AutomationStub.DoStep();
        }

        [Then(@"ipsum vitae (\d+) Vestibulum")]
        public void ThenFeugiatVehiculaArcuPurus(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"Donec vulputate eu lacinia (\d+)")]
        public void GivenUtNecMolestieJusto(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

    }
}
