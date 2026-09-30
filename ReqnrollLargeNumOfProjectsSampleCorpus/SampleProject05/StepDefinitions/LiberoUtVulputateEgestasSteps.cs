using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class LiberoUtVulputateEgestasSteps
    {
        [Then(@"aliquet Class ultricies sed (\d+)")]
        public void ThenPhasellusNullaDuisEleifend(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"""(.*)"" tempor Phasellus amet")]
        public void GivenLigulaEfficiturEgetNec(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"dui (\d+) cursus Suspendisse viverra")]
        public void ThenSemPortaQuamEleifend(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"sem id tincidunt egestas")]
        public void ThenCurabiturPerTempusPer()
        {
           AutomationStub.DoStep();
        }

        [Given(@"(\d+) pretium Phasellus")]
        public void GivenAdipiscingVitaeLigulaHendrerit(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"placerat nostra et")]
        public void GivenCursusCommodoSitMolestie()
        {
           AutomationStub.DoStep();
        }

    }
}
