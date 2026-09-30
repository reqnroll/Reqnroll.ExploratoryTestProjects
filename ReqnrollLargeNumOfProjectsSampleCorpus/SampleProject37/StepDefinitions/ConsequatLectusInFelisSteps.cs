using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class ConsequatLectusInFelisSteps
    {
        [Then(@"a mi ""(.*)""")]
        public void ThenInceptosPerNecEgestas(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"(\d+) ""(.*)"" condimentum nec torquent")]
        public void ThenLectusConsequatEgestasOrci(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"Quisque felis tempor Nulla")]
        public void GivenIpsumIaculisNullaMi()
        {
           AutomationStub.DoStep();
        }

        [When(@"laoreet ""(.*)"" hendrerit non mi")]
        public void WhenDonecVitaeAVulputate(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"lorem mi vulputate (\d+) odio")]
        public void GivenInCommodoEratViverra(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"faucibus (\d+) sociosqu")]
        public void WhenNuncPurusSitLorem(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

    }
}
