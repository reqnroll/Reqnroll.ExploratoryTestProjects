using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class LacusAugueScelerisqueLigulaSteps
    {
        [Then(@"suscipit risus tortor")]
        public void ThenUltriciesDictumAnteViverra()
        {
           AutomationStub.DoStep();
        }

        [Given(@"vitae eleifend vel ""(.*)"" dolor")]
        public void GivenVenenatisNostraPhasellusArcu(string p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"""(.*)"" pretium ""(.*)""")]
        public void WhenSuspendisseAliquamLeoDignissim(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"sed lectus nec blandit")]
        public void GivenDictumDapibusLoremMassa(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"est vel leo")]
        public void WhenInVenenatisPorttitorAugue()
        {
           AutomationStub.DoStep();
        }

        [Given(@"tortor et (\d+)")]
        public void GivenVitaeMattisMaurisElit(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"nulla nec dui (\d+)")]
        public void WhenFelisVelEuVitae(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"dapibus amet iaculis condimentum non")]
        public void GivenLoremNuncScelerisqueIpsum()
        {
           AutomationStub.DoStep();
        }

    }
}
