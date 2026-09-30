using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class CongueSapienCondimentumEnimSteps
    {
        [Then(@"nec scelerisque porta (\d+) iaculis")]
        public void ThenInVehiculaUrnaVolutpat(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"nulla nec dui (\d+)")]
        public void WhenPerPretiumIpsumSapien(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"condimentum commodo nec iaculis")]
        public void GivenLoremAdipiscingEgestasCommodo()
        {
           AutomationStub.DoStep();
        }

        [Given(@"nunc augue felis cursus")]
        public void GivenMaecenasEtiamElitScelerisque(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"(\d+) dignissim ""(.*)""")]
        public void ThenFinibusCurabiturAliquamOrci(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"ante sapien nec")]
        public void ThenAccumsanIdFinibusNunc()
        {
           AutomationStub.DoStep();
        }

    }
}
