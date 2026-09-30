using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class CongueMassaLobortisIpsumSteps
    {
        [Given(@"(\d+) nec vulputate eleifend blandit")]
        public void GivenPortaCondimentumAnteEuismod(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"""(.*)"" rhoncus ""(.*)"" odio")]
        public void GivenSuscipitVulputateQuisqueEros(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"ac litora Phasellus risus")]
        public void GivenInAtCondimentumSed()
        {
           AutomationStub.DoStep();
        }

        [Given(@"commodo Suspendisse Nulla")]
        public void GivenSedLacusDonecRisus()
        {
           AutomationStub.DoStep();
        }

        [When(@"lorem hendrerit Integer Donec")]
        public void WhenUltriciesRisusSitSed()
        {
           AutomationStub.DoStep();
        }

        [Then(@"(\d+) ""(.*)"" ""(.*)""")]
        public void ThenTortorMassaLobortisElementum(int p0, string p1, string p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

    }
}
