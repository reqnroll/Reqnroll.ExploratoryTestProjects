using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class VitaeNisiTemporNostraSteps
    {
        [Given(@"""(.*)"" eu aliquet")]
        public void GivenQuamVulputateVestibulumCursus(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"Quisque ligula accumsan scelerisque nulla")]
        public void ThenExANonEt()
        {
           AutomationStub.DoStep();
        }

        [Then(@"elit (\d+) Lorem bibendum")]
        public void ThenImperdietTinciduntLiberoAugue(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"""(.*)"" nec eu Lorem pellentesque")]
        public void ThenMollisAugueAnteNisi(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"eu (\d+) eros")]
        public void ThenExAliquamMaurisLobortis(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"felis tincidunt Suspendisse congue")]
        public void GivenQuisqueSitAcSed()
        {
           AutomationStub.DoStep();
        }

    }
}
