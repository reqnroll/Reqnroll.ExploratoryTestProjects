using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class PhasellusSitVenenatisDuisSteps
    {
        [When(@"nec conubia sapien")]
        public void WhenVitaeNisiLaoreetEx(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"""(.*)"" interdum Quisque (\d+)")]
        public void ThenScelerisqueVitaeBlanditMolestie(string p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"felis (\d+) ante")]
        public void GivenLectusDictumIpsumVulputate(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"tempus molestie ipsum massa")]
        public void WhenAtVelMassaDiam()
        {
           AutomationStub.DoStep();
        }

        [Then(@"(\d+) (\d+) Donec auctor Class")]
        public void ThenSedAugueInEu(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"lacus ""(.*)"" (\d+)")]
        public void WhenUrnaDuiVitaeVitae(string p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"urna (\d+) suscipit")]
        public void ThenSitNuncNostraId(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"""(.*)"" (\d+) ""(.*)"" lobortis")]
        public void WhenMiMolestieFermentumPurus(string p0, int p1, string p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

    }
}
