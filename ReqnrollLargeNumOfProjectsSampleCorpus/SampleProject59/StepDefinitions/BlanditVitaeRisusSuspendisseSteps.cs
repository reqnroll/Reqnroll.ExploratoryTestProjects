using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class BlanditVitaeRisusSuspendisseSteps
    {
        [Given(@"""(.*)"" fermentum vulputate sagittis lobortis")]
        public void GivenBlanditQuamVestibulumVehicula(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"in In id")]
        public void ThenSemperOrciDictumLigula(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"dolor (\d+) ""(.*)"" in")]
        public void GivenAdVenenatisBlanditClass(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"accumsan (\d+) Morbi id")]
        public void WhenIntegerMaecenasEgetLectus(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"(\d+) ""(.*)"" conubia conubia mi")]
        public void GivenSitPortaFelisDictum(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"amet ""(.*)"" in vitae tincidunt")]
        public void ThenSitExElementumMassa(string p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"vitae suscipit Phasellus (\d+)")]
        public void ThenSemDiamPharetraNec(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"blandit imperdiet leo erat dignissim")]
        public void WhenVulputateCondimentumPhasellusLigula(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
