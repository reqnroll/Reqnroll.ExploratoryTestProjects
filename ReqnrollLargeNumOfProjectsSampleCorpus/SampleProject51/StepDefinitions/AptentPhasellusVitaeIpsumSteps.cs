using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class AptentPhasellusVitaeIpsumSteps
    {
        [When(@"vitae efficitur (\d+) scelerisque")]
        public void WhenAuctorUtSuspendisseViverra(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"""(.*)"" rhoncus ""(.*)"" odio")]
        public void GivenInLacusLaoreetLectus(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"ad non faucibus mattis pretium")]
        public void ThenCurabiturNostraTristiqueInceptos()
        {
           AutomationStub.DoStep();
        }

        [When(@"pharetra et malesuada viverra")]
        public void WhenUltriciesUtVitaeSuspendisse()
        {
           AutomationStub.DoStep();
        }

        [Given(@"nostra imperdiet vitae dignissim")]
        public void GivenVitaeAptentLigulaNon()
        {
           AutomationStub.DoStep();
        }

        [Given(@"""(.*)"" eu aliquet")]
        public void GivenSociosquQuisOrciDonec(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"(\d+) risus augue")]
        public void ThenSemViverraIntegerNisi(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"id dignissim Suspendisse")]
        public void WhenJustoLacusMollisOrci()
        {
           AutomationStub.DoStep();
        }

    }
}
