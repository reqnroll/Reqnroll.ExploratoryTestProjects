using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class OdioJustoEleifendJustoSteps
    {
        [Given(@"""(.*)"" litora (\d+)")]
        public void GivenInClassNullaSodales(string p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"elit Phasellus sollicitudin")]
        public void WhenMolestieEgetNuncPulvinar()
        {
           AutomationStub.DoStep();
        }

        [Then(@"in in In sem")]
        public void ThenFelisEgestasInNisi()
        {
           AutomationStub.DoStep();
        }

        [Given(@"placerat nostra et")]
        public void GivenAliquetAugueFelisNon()
        {
           AutomationStub.DoStep();
        }

        [Then(@"(\d+) luctus (\d+) in")]
        public void ThenMolestieQuisSapienEleifend(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"In at conubia porta")]
        public void ThenElitLeoNullaSem(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"""(.*)"" amet (\d+) non Nam")]
        public void ThenPortaBibendumSapienTempor(string p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"(\d+) nisi odio ""(.*)""")]
        public void WhenJustoRisusEleifendAugue(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

    }
}
