using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class AmetInNuncVenenatisSteps
    {
        [Then(@"justo sed volutpat id ""(.*)""")]
        public void ThenVitaeEuAtVulputate(string p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"""(.*)"" eu quis per lobortis")]
        public void ThenSitCongueAtNulla(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"(\d+) ""(.*)"" conubia conubia mi")]
        public void GivenPellentesquePhasellusConsecteturSed(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"venenatis id laoreet ""(.*)"" venenatis")]
        public void WhenVitaeEleifendVelLectus(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"laoreet ""(.*)"" Quisque lobortis blandit")]
        public void GivenDolorPhasellusExScelerisque(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"(\d+) dignissim ""(.*)""")]
        public void ThenIpsumEtSuspendisseCurabitur(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"Lorem eget leo (\d+) Donec")]
        public void WhenErosInNibhLeo(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"nostra imperdiet vitae dignissim")]
        public void GivenLigulaPretiumNecBlandit()
        {
           AutomationStub.DoStep();
        }

        [Then(@"""(.*)"" (\d+) at (\d+) suscipit")]
        public void ThenBlanditLiberoFelisCurabitur(string p0, int p1, int p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

        [Given(@"id nulla (\d+)")]
        public void GivenVestibulumUltriciesLiberoFinibus(int p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
