using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class DapibusLuctusLiberoEuSteps
    {
        [Given(@"libero laoreet massa felis ipsum")]
        public void GivenMaecenasDolorMassaCras()
        {
           AutomationStub.DoStep();
        }

        [Given(@"nostra molestie ut")]
        public void GivenTristiqueEtAliquetEt()
        {
           AutomationStub.DoStep();
        }

        [Given(@"ligula eu commodo justo")]
        public void GivenDonecImperdietAugueA(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"commodo vulputate cursus finibus")]
        public void WhenCommodoSedMassaCursus()
        {
           AutomationStub.DoStep();
        }

        [Then(@"(\d+) (\d+) Donec auctor Class")]
        public void ThenLectusFeugiatCursusEget(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"vel in diam")]
        public void WhenIaculisDuisNisiNeque()
        {
           AutomationStub.DoStep();
        }

    }
}
