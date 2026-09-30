using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class NonNullaErosCrasSteps
    {
        [Then(@"sapien ""(.*)"" id nec")]
        public void ThenSedAuctorScelerisqueConubia(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"a (\d+) Phasellus amet")]
        public void WhenVitaeEuismodTempusTempor(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"dapibus amet iaculis condimentum non")]
        public void GivenInBlanditEleifendVestibulum()
        {
           AutomationStub.DoStep();
        }

        [Then(@"(\d+) justo ""(.*)""")]
        public void ThenNonPortaBlanditLeo(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"diam ""(.*)"" (\d+) inceptos")]
        public void GivenVestibulumDuisVolutpatCursus(string p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"lorem porta commodo eu")]
        public void ThenPretiumElementumNullaCongue(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
