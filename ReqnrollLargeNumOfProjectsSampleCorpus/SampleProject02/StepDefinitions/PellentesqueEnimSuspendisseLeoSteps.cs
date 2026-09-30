using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class PellentesqueEnimSuspendisseLeoSteps
    {
        [Then(@"nec scelerisque porta (\d+) iaculis")]
        public void ThenNostraUltriciesNisiAt(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"mi cursus molestie urna")]
        public void GivenDapibusTorquentPulvinarNon()
        {
           AutomationStub.DoStep();
        }

        [Given(@"""(.*)"" vitae Cras")]
        public void GivenDiamPortaLeoMassa(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"urna (\d+) suscipit")]
        public void ThenBlanditElementumEuInceptos(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"sem per vitae")]
        public void GivenVelScelerisqueIaculisBlandit()
        {
           AutomationStub.DoStep();
        }

        [Then(@"""(.*)"" eu quis per lobortis")]
        public void ThenUtCommodoNullaPhasellus(string p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
