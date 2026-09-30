using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class TristiqueEnimAnteCongueSteps
    {
        [When(@"tempus porta in justo id")]
        public void WhenSagittisEfficiturUrnaSed()
        {
           AutomationStub.DoStep();
        }

        [When(@"venenatis id laoreet ""(.*)"" venenatis")]
        public void WhenElitDictumClassA(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"""(.*)"" sapien nec iaculis massa")]
        public void WhenEtUrnaLoremFermentum(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"mauris vel ""(.*)"" felis")]
        public void GivenElementumSedEgestasHimenaeos(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"""(.*)"" malesuada a ""(.*)""")]
        public void ThenLaoreetDignissimVitaeDuis(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"condimentum egestas neque eu")]
        public void WhenRisusEratVitaeEget(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"Lorem eget leo (\d+) Donec")]
        public void WhenSemNullaNibhLibero(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"quam ""(.*)"" elit ""(.*)"" ut")]
        public void GivenLiberoNullaUtAc(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

    }
}
