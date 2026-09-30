using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class VelHimenaeosIdLectusSteps
    {
        [Given(@"mi cursus molestie urna")]
        public void GivenLigulaTempusEnimElementum()
        {
           AutomationStub.DoStep();
        }

        [When(@"venenatis augue diam magna (\d+)")]
        public void WhenLaoreetDiamSitEfficitur(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"""(.*)"" eu quis per lobortis")]
        public void ThenVitaeLeoTemporIn(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"tincidunt (\d+) tempor libero")]
        public void WhenLobortisMattisQuisqueAmet(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"""(.*)"" ultricies ""(.*)""")]
        public void GivenBibendumElitUtSapien(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"dui non vel ""(.*)"" nec")]
        public void WhenGravidaNullaLoremNon(string p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
