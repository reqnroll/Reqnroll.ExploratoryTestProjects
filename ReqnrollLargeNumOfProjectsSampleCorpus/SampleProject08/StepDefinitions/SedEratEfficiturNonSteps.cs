using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class SedEratEfficiturNonSteps
    {
        [Given(@"felis nec Suspendisse molestie")]
        public void GivenUtAmetSedSuscipit()
        {
           AutomationStub.DoStep();
        }

        [Given(@"orci eu augue (\d+)")]
        public void GivenRisusTortorBlanditNec(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"mauris vel ""(.*)"" felis")]
        public void GivenSedSedUrnaEget(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"(\d+) luctus (\d+) in")]
        public void ThenErosLigulaCondimentumUllamcorper(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"(\d+) ""(.*)"" conubia conubia mi")]
        public void GivenNecMagnaBibendumAugue(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"adipiscing massa molestie")]
        public void WhenLectusDuisSitEx()
        {
           AutomationStub.DoStep();
        }

    }
}
