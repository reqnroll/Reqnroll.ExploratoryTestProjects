using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class SociosquDonecPortaAuctorSteps
    {
        [When(@"laoreet ""(.*)"" hendrerit non mi")]
        public void WhenAptentMiInNeque(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"""(.*)"" vitae Cras")]
        public void GivenEtLiberoVestibulumEleifend(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"in dignissim tempor massa")]
        public void WhenElitAmetAliquetLeo()
        {
           AutomationStub.DoStep();
        }

        [Given(@"sem per vitae")]
        public void GivenMattisQuamErosEleifend()
        {
           AutomationStub.DoStep();
        }

        [Then(@"quis felis nunc")]
        public void ThenNonInElitTempus()
        {
           AutomationStub.DoStep();
        }

        [Given(@"(\d+) nec vulputate eleifend blandit")]
        public void GivenLoremBibendumFusceTorquent(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"dolor (\d+) ""(.*)"" in")]
        public void GivenSagittisEgestasNisiElementum(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"ad finibus augue")]
        public void ThenDonecAmetJustoFermentum()
        {
           AutomationStub.DoStep();
        }

    }
}
