using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class ElitIdErosNostraSteps
    {
        [When(@"lacus ""(.*)"" (\d+)")]
        public void WhenEtAcSagittisEros(string p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"(\d+) luctus (\d+) in")]
        public void ThenScelerisqueUltriciesDuiFelis(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"(\d+) justo Sed ""(.*)""")]
        public void WhenSitCommodoAmetUt(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"(\d+) dignissim ""(.*)""")]
        public void ThenSemInterdumBlanditA(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"sed lectus nec blandit")]
        public void GivenNullaMolestieAtMassa(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"commodo eget magna molestie")]
        public void WhenNecNamInMollis(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
