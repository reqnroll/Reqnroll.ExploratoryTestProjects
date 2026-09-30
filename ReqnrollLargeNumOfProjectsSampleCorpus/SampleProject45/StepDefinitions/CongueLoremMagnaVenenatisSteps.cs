using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class CongueLoremMagnaVenenatisSteps
    {
        [Then(@"In vitae (\d+) ""(.*)""")]
        public void ThenCommodoRisusEuNulla(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"scelerisque dapibus porttitor")]
        public void GivenAConsecteturAAt()
        {
           AutomationStub.DoStep();
        }

        [When(@"eget in Phasellus urna")]
        public void WhenTemporIntegerInTellus()
        {
           AutomationStub.DoStep();
        }

        [Given(@"molestie in odio In ""(.*)""")]
        public void GivenMagnaMiSedLacus(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"""(.*)"" eu id nec")]
        public void GivenEleifendNecCommodoAugue(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"egestas porta tortor")]
        public void GivenCongueAugueMiUrna(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
