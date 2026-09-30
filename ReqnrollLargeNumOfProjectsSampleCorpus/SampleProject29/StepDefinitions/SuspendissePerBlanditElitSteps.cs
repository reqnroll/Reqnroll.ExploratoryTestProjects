using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class SuspendissePerBlanditElitSteps
    {
        [Given(@"orci eu augue (\d+)")]
        public void GivenConubiaAUtLibero(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"(\d+) molestie odio (\d+) dolor")]
        public void GivenCommodoElitVulputatePer(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"iaculis ipsum Etiam a (\d+)")]
        public void WhenNonMassaQuamConsequat(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"nostra faucibus (\d+) Vestibulum")]
        public void GivenSemBlanditMolestieTempus(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"""(.*)"" (\d+) ""(.*)"" lobortis")]
        public void WhenHendreritMiPellentesqueQuisque(string p0, int p1, string p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

        [When(@"accumsan (\d+) Morbi id")]
        public void WhenAmetCommodoAliquetFermentum(int p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
