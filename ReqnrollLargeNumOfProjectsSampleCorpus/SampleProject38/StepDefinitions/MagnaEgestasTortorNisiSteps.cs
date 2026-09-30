using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class MagnaEgestasTortorNisiSteps
    {
        [Then(@"(\d+) luctus (\d+) in")]
        public void ThenMaecenasEratNullaJusto(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"(\d+) eros felis at lorem")]
        public void GivenSollicitudinVariusCursusSem(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"""(.*)"" fermentum vulputate sagittis lobortis")]
        public void GivenNecCongueNuncFermentum(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"""(.*)"" sapien nec iaculis massa")]
        public void WhenSuscipitDonecExViverra(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"vel sed dolor vestibulum")]
        public void WhenFeugiatAptentVulputateNon()
        {
           AutomationStub.DoStep();
        }

        [Given(@"(\d+) ""(.*)"" conubia conubia mi")]
        public void GivenElitInUrnaLibero(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

    }
}
