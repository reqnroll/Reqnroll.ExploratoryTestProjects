using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class VelCursusDonecRhoncusSteps
    {
        [Then(@"""(.*)"" nec eu Lorem pellentesque")]
        public void ThenEtAliquetExMi(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"lorem dictum (\d+) accumsan")]
        public void ThenSitTacitiExEget(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"sodales Morbi hendrerit")]
        public void WhenAnteQuisqueNonDui()
        {
           AutomationStub.DoStep();
        }

        [When(@"Maecenas felis (\d+)")]
        public void WhenOrciVulputateLectusClass(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"(\d+) in quis volutpat")]
        public void GivenAdVitaeDapibusAnte(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"(\d+) nec vulputate eleifend blandit")]
        public void GivenSedElitCursusNostra(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"In pretium ligula consequat orci")]
        public void WhenInElitNullaVitae()
        {
           AutomationStub.DoStep();
        }

        [Given(@"nec ligula Sed")]
        public void GivenBlanditIaculisSociosquSodales()
        {
           AutomationStub.DoStep();
        }

    }
}
