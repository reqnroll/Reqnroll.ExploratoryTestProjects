using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class DolorIntegerErosElitSteps
    {
        [When(@"a (\d+) Phasellus amet")]
        public void WhenSuspendisseLacusVitaeFelis(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"finibus leo ""(.*)"" blandit")]
        public void ThenLaciniaTristiquePhasellusElit(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"luctus urna (\d+) condimentum ""(.*)""")]
        public void GivenQuisqueAcEleifendEu(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"ex dignissim elementum")]
        public void ThenEuEtHendreritEt()
        {
           AutomationStub.DoStep();
        }

        [When(@"commodo elit et eget Integer")]
        public void WhenLitoraErosEfficiturIn()
        {
           AutomationStub.DoStep();
        }

        [Then(@"(\d+) ""(.*)"" condimentum nec torquent")]
        public void ThenDuiTellusQuisA(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"(\d+) lobortis diam (\d+) ut")]
        public void ThenPorttitorAliquamDolorViverra(int p0, int p1, Table p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

        [Given(@"(\d+) molestie odio (\d+) dolor")]
        public void GivenTortorUtEgestasSodales(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

    }
}
