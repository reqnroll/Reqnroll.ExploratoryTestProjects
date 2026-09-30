using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class PortaInLaoreetAnteSteps
    {
        [Then(@"(\d+) ut viverra vestibulum ""(.*)""")]
        public void ThenMassaDonecAliquamLaoreet(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"lorem dictum (\d+) accumsan")]
        public void ThenSapienRisusDiamVulputate(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"mollis dapibus tristique ""(.*)""")]
        public void GivenLectusPulvinarLuctusEros(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"tristique risus ""(.*)"" placerat inceptos")]
        public void GivenGravidaInSapienVel(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"(\d+) ""(.*)"" conubia conubia mi")]
        public void GivenMollisNibhCurabiturNec(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"vitae malesuada suscipit")]
        public void ThenSodalesMaurisAmetAt(string p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
