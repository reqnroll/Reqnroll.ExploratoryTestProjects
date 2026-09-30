using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class ScelerisqueNequePortaEuSteps
    {
        [When(@"id id neque tempor dapibus")]
        public void WhenAliquetSedSemDiam()
        {
           AutomationStub.DoStep();
        }

        [Given(@"""(.*)"" fermentum vulputate sagittis lobortis")]
        public void GivenVulputateACommodoCommodo(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"mauris eu Sed")]
        public void ThenEfficiturBibendumNullaLigula(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"ante libero ut")]
        public void ThenSitEnimRisusDolor()
        {
           AutomationStub.DoStep();
        }

        [Then(@"Fusce ""(.*)"" sit")]
        public void ThenTortorSuspendisseIdMolestie(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"augue id tristique erat eget")]
        public void GivenMalesuadaSodalesMiLibero()
        {
           AutomationStub.DoStep();
        }

        [When(@"lacus ""(.*)"" (\d+)")]
        public void WhenDignissimElementumVariusTempor(string p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"commodo et conubia")]
        public void WhenScelerisqueMagnaInEt()
        {
           AutomationStub.DoStep();
        }

        [Given(@"mi cursus molestie urna")]
        public void GivenElitEtiamLoremLobortis()
        {
           AutomationStub.DoStep();
        }

        [Given(@"orci eu augue (\d+)")]
        public void GivenAdJustoElitPulvinar(int p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
