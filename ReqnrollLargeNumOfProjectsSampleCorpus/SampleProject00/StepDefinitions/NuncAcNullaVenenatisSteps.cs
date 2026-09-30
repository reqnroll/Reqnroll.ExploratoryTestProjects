using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class NuncAcNullaVenenatisSteps
    {
        [When(@"est dictum Integer conubia")]
        public void WhenPharetraEtMalesuadaViverra()
        {
           AutomationStub.DoStep();
        }

        [When(@"Lorem eget leo (\d+) Donec")]
        public void WhenVenenatisAugueCrasAliquet(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"ante sapien nec")]
        public void ThenMolestieNecPerAliquam()
        {
           AutomationStub.DoStep();
        }

        [Given(@"condimentum commodo nec iaculis")]
        public void GivenAtAMiVarius()
        {
           AutomationStub.DoStep();
        }

        [When(@"vel sed dolor vestibulum")]
        public void WhenVehiculaScelerisqueNecVel()
        {
           AutomationStub.DoStep();
        }

        [When(@"in elementum ""(.*)""")]
        public void WhenAmetAuctorVelLigula(string p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
