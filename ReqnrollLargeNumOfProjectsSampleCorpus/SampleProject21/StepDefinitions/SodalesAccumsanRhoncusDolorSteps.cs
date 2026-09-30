using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class SodalesAccumsanRhoncusDolorSteps
    {
        [Then(@"ipsum sapien lorem")]
        public void ThenUtMassaAnteA()
        {
           AutomationStub.DoStep();
        }

        [Given(@"Donec ""(.*)"" eget amet")]
        public void GivenInSitMaecenasEx(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"nunc augue felis cursus")]
        public void GivenDuisElitEgetEget(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"cursus tincidunt (\d+) (\d+) Morbi")]
        public void ThenAmetEgetAugueIn(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"felis nec Suspendisse molestie")]
        public void GivenTortorEgestasSedLobortis()
        {
           AutomationStub.DoStep();
        }

        [When(@"lacus ""(.*)"" (\d+)")]
        public void WhenMaurisCommodoDiamSed(string p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

    }
}
