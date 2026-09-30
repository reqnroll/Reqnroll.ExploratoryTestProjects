using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class PlaceratScelerisqueSemElementumSteps
    {
        [Then(@"(\d+) luctus (\d+) in")]
        public void ThenVitaeMalesuadaVestibulumLobortis(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"sed lectus nec blandit")]
        public void GivenNecAcInOrci(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"(\d+) eros felis at lorem")]
        public void GivenQuisLaoreetInPorta(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"laoreet ""(.*)"" hendrerit non mi")]
        public void WhenVariusABlanditQuisque(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"quis ipsum erat")]
        public void WhenNonConubiaAuctorNulla()
        {
           AutomationStub.DoStep();
        }

        [Given(@"massa justo lectus pretium Praesent")]
        public void GivenNecEuLoremPellentesque()
        {
           AutomationStub.DoStep();
        }

        [Given(@"risus ultricies ac")]
        public void GivenNamSuspendisseMassaEget()
        {
           AutomationStub.DoStep();
        }

        [Given(@"taciti mollis blandit egestas eu")]
        public void GivenCursusLobortisEuSit(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"condimentum lacinia blandit")]
        public void ThenMolestieMolestieCondimentumLigula()
        {
           AutomationStub.DoStep();
        }

        [When(@"(\d+) justo Sed ""(.*)""")]
        public void WhenNisiAugueRisusSuspendisse(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

    }
}
