using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class SuspendisseEnimExPlaceratSteps
    {
        [Given(@"vitae eros tempor varius")]
        public void GivenAtFinibusVulputateEros()
        {
           AutomationStub.DoStep();
        }

        [Then(@"fermentum ""(.*)"" in sociosqu")]
        public void ThenEgetTortorSitDiam(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"condimentum (\d+) ""(.*)""")]
        public void ThenTellusVitaeDignissimRisus(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"id id neque tempor dapibus")]
        public void WhenVulputateAdPhasellusNunc()
        {
           AutomationStub.DoStep();
        }

        [Given(@"laoreet ""(.*)"" Quisque lobortis blandit")]
        public void GivenViverraPerIpsumIn(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"nec conubia sapien")]
        public void WhenTortorMaecenasTacitiDapibus(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
