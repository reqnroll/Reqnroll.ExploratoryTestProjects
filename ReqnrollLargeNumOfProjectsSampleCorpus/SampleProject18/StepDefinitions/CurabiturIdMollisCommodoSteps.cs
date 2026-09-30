using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class CurabiturIdMollisCommodoSteps
    {
        [Given(@"laoreet ""(.*)"" Quisque lobortis blandit")]
        public void GivenLiberoImperdietSodalesVitae(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"adipiscing massa molestie")]
        public void WhenEnimSodalesMassaAt()
        {
           AutomationStub.DoStep();
        }

        [Given(@"dolor (\d+) ""(.*)"" in")]
        public void GivenEgestasLuctusEgetA(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"(\d+) nisi odio ""(.*)""")]
        public void WhenPhasellusTortorVitaeAdipiscing(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"ante sapien nec")]
        public void ThenSitAugueUrnaFinibus()
        {
           AutomationStub.DoStep();
        }

        [Then(@"(\d+) himenaeos ""(.*)""")]
        public void ThenEuPharetraEgetFaucibus(int p0, string p1, Table p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

    }
}
