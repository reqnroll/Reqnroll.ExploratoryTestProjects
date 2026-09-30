using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class LiberoIaculisSitSemSteps
    {
        [Then(@"Nunc pulvinar Sed")]
        public void ThenIpsumCurabiturAccumsanScelerisque()
        {
           AutomationStub.DoStep();
        }

        [Then(@"justo sed volutpat id ""(.*)""")]
        public void ThenClassLaoreetPharetraPulvinar(string p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"""(.*)"" dui a")]
        public void ThenProinLeoNullaEu(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"Curabitur Aliquam orci accumsan id")]
        public void ThenLoremElementumMattisNunc()
        {
           AutomationStub.DoStep();
        }

        [When(@"commodo et conubia")]
        public void WhenLoremVitaeJustoMassa()
        {
           AutomationStub.DoStep();
        }

        [Given(@"vitae Nam Curabitur mi viverra")]
        public void GivenMassaEnimTemporPlacerat()
        {
           AutomationStub.DoStep();
        }

    }
}
