using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class ErosLiberoAugueScelerisqueSteps
    {
        [Then(@"suscipit non enim")]
        public void ThenUltriciesSociosquCursusUrna()
        {
           AutomationStub.DoStep();
        }

        [When(@"quis ipsum erat")]
        public void WhenMalesuadaMolestieVulputateSapien()
        {
           AutomationStub.DoStep();
        }

        [Given(@"vitae Nam Curabitur mi viverra")]
        public void GivenAugueEgetUtVestibulum()
        {
           AutomationStub.DoStep();
        }

        [Given(@"laoreet ""(.*)"" Quisque lobortis blandit")]
        public void GivenCommodoVulputateCursusFinibus(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"aliquet Class ultricies sed (\d+)")]
        public void ThenDapibusIdDonecDignissim(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"(\d+) himenaeos ""(.*)""")]
        public void ThenElitSitSedElit(int p0, string p1, Table p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

        [Then(@"In at conubia porta")]
        public void ThenSuspendisseDonecVulputateEu(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"(\d+) luctus (\d+) in")]
        public void ThenLaciniaAnteLeoDapibus(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

    }
}
