using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class PurusEuEgestasNibhSteps
    {
        [Then(@"""(.*)"" eu justo")]
        public void ThenNuncVitaeSemUt(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"nulla nec dui (\d+)")]
        public void WhenMalesuadaCommodoSociosquEnim(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"sit enim risus")]
        public void WhenSedPhasellusLacusSodales(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"""(.*)"" malesuada a ""(.*)""")]
        public void ThenCommodoSuspendisseIdSit(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"porta orci nulla (\d+) risus")]
        public void GivenVenenatisSitAmetSociosqu(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"enim vitae Suspendisse Lorem nunc")]
        public void GivenElitElitTorquentLeo()
        {
           AutomationStub.DoStep();
        }

    }
}
