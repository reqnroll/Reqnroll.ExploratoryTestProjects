using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class MaurisNonEuEleifendSteps
    {
        [Given(@"quam ""(.*)"" elit ""(.*)"" ut")]
        public void GivenInDonecVulputateMi(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"Morbi lobortis Suspendisse (\d+)")]
        public void GivenVitaeQuisqueInVestibulum(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"felis (\d+) ante")]
        public void GivenDignissimTemporMassaTincidunt(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"blandit imperdiet leo erat dignissim")]
        public void WhenMaurisAcEratUt(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"augue blandit tristique")]
        public void WhenLigulaEgetMagnaTempor()
        {
           AutomationStub.DoStep();
        }

        [Then(@"tellus taciti Aliquam nunc (\d+)")]
        public void ThenScelerisqueLectusSemMalesuada(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

    }
}
