using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class ElitAliquetBlanditEgetSteps
    {
        [Then(@"vitae Aliquam Nam commodo")]
        public void ThenInNisiConubiaSed()
        {
           AutomationStub.DoStep();
        }

        [When(@"venenatis id laoreet ""(.*)"" venenatis")]
        public void WhenPurusNonVelPulvinar(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"dapibus amet iaculis condimentum non")]
        public void GivenTristiqueMassaSitEuismod()
        {
           AutomationStub.DoStep();
        }

        [Given(@"nostra imperdiet vitae dignissim")]
        public void GivenVenenatisAmetPulvinarAmet()
        {
           AutomationStub.DoStep();
        }

        [Then(@"Fusce ""(.*)"" sit")]
        public void ThenTortorCurabiturEuMauris(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"massa justo lectus pretium Praesent")]
        public void GivenSuscipitAdipiscingLeoUltricies()
        {
           AutomationStub.DoStep();
        }

        [Then(@"faucibus ligula (\d+) porta")]
        public void ThenUtVelAugueGravida(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"vitae orci tellus")]
        public void ThenViverraSemAImperdiet()
        {
           AutomationStub.DoStep();
        }

    }
}
