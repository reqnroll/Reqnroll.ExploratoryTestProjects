using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class TempusCommodoMiBlanditSteps
    {
        [Given(@"ut venenatis ut")]
        public void GivenPortaMalesuadaEuCurabitur()
        {
           AutomationStub.DoStep();
        }

        [When(@"dapibus ipsum (\d+) molestie")]
        public void WhenVehiculaNecUrnaAccumsan(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"ac litora Phasellus risus")]
        public void GivenEgestasQuisqueDuiLigula()
        {
           AutomationStub.DoStep();
        }

        [When(@"""(.*)"" porta ""(.*)"" (\d+)")]
        public void WhenNecNuncIntegerAt(string p0, string p1, int p2, Table p3)
        {
           AutomationStub.DoStep(p0, p1, p2, p3);
        }

        [When(@"in elementum ""(.*)""")]
        public void WhenDictumCongueUtCongue(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"in dignissim tempor massa")]
        public void WhenDolorVitaeCursusCongue()
        {
           AutomationStub.DoStep();
        }

        [Given(@"sem per vitae")]
        public void GivenTempusNecTortorEt()
        {
           AutomationStub.DoStep();
        }

        [Given(@"enim vitae Suspendisse Lorem nunc")]
        public void GivenLectusPhasellusOdioIpsum()
        {
           AutomationStub.DoStep();
        }

    }
}
