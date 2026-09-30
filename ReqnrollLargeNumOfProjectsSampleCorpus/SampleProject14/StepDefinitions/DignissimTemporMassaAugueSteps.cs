using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class DignissimTemporMassaAugueSteps
    {
        [Given(@"taciti mollis blandit egestas eu")]
        public void GivenQuisqueMaurisEtLorem(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"est dictum Integer conubia")]
        public void WhenNonEfficiturCondimentumLectus()
        {
           AutomationStub.DoStep();
        }

        [Then(@"Fusce ""(.*)"" sit")]
        public void ThenCursusTinciduntDonecMassa(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"vitae suscipit Phasellus (\d+)")]
        public void ThenMorbiSitNecLitora(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"justo sed volutpat id ""(.*)""")]
        public void ThenDiamAugueTellusTortor(string p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"egestas efficitur tellus")]
        public void WhenNecLacusCongueAliquet()
        {
           AutomationStub.DoStep();
        }

    }
}
