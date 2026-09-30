using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class QuisMassaBibendumPhasellusSteps
    {
        [Then(@"vitae suscipit Phasellus (\d+)")]
        public void ThenTellusAnteNonImperdiet(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"egestas porta tortor")]
        public void GivenTristiqueBibendumMiElit(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"sem per vitae")]
        public void GivenBibendumLeoInceptosPlacerat()
        {
           AutomationStub.DoStep();
        }

        [When(@"est dictum Integer conubia")]
        public void WhenNostraEtEuTempus()
        {
           AutomationStub.DoStep();
        }

        [When(@"vel sed dolor vestibulum")]
        public void WhenExScelerisquePortaPorta()
        {
           AutomationStub.DoStep();
        }

        [Then(@"nec scelerisque porta (\d+) iaculis")]
        public void ThenDonecEstOdioAmet(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"urna (\d+) suscipit")]
        public void ThenVolutpatNonNamRisus(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"felis nec Suspendisse molestie")]
        public void GivenVitaeAptentAMassa()
        {
           AutomationStub.DoStep();
        }

        [Given(@"""(.*)"" eu id nec")]
        public void GivenExMassaAmetUt(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"tempus molestie ipsum massa")]
        public void WhenInLectusSodalesVel()
        {
           AutomationStub.DoStep();
        }

    }
}
