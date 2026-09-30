using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class VolutpatSagittisInEnimSteps
    {
        [Then(@"euismod ut et Etiam")]
        public void ThenAmetExPerIn()
        {
           AutomationStub.DoStep();
        }

        [When(@"blandit ""(.*)"" nulla justo")]
        public void WhenLoremConsecteturFermentumEu(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"vitae Maecenas non dictum purus")]
        public void ThenEtUtErosLacinia()
        {
           AutomationStub.DoStep();
        }

        [Then(@"Class urna in libero")]
        public void ThenEfficiturCurabiturSemperSed()
        {
           AutomationStub.DoStep();
        }

        [Given(@"condimentum ""(.*)"" nec magna")]
        public void GivenEuAmetIdCurabitur(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"Ut ""(.*)"" (\d+) Class et")]
        public void ThenAmetUtAJusto(string p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

    }
}
