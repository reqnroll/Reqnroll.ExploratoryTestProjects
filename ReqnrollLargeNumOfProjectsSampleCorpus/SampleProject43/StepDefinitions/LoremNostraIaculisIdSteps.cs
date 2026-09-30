using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class LoremNostraIaculisIdSteps
    {
        [Given(@"risus (\d+) (\d+)")]
        public void GivenSagittisIdVestibulumIn(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"dolor blandit vulputate eu")]
        public void WhenPhasellusSedCondimentumIn()
        {
           AutomationStub.DoStep();
        }

        [Given(@"augue id tristique erat eget")]
        public void GivenDonecMagnaAmetNon()
        {
           AutomationStub.DoStep();
        }

        [Given(@"felis tincidunt Suspendisse congue")]
        public void GivenVulputateEgetNuncBibendum()
        {
           AutomationStub.DoStep();
        }

        [Then(@"vitae orci tellus")]
        public void ThenEuUrnaLigulaAugue()
        {
           AutomationStub.DoStep();
        }

        [Then(@"aliquet Class ultricies sed (\d+)")]
        public void ThenVulputateEgetElementumFelis(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"ante sapien nec")]
        public void ThenLacusSagittisPhasellusAugue()
        {
           AutomationStub.DoStep();
        }

        [Then(@"commodo (\d+) ligula commodo urna")]
        public void ThenEfficiturTortorUtFelis(int p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
