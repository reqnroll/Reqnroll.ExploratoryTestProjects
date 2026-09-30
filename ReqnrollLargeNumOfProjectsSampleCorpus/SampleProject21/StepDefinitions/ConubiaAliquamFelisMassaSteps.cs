using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class ConubiaAliquamFelisMassaSteps
    {
        [Given(@"(\d+) suscipit adipiscing leo ultricies")]
        public void GivenMalesuadaCommodoFaucibusIn(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"(\d+) ""(.*)"" sit quis")]
        public void WhenEuJustoANunc(int p0, string p1, Table p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

        [Then(@"justo magna eget")]
        public void ThenAccumsanSodalesInConsequat(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"libero dignissim elementum varius tempor")]
        public void ThenMiSodalesMiBlandit()
        {
           AutomationStub.DoStep();
        }

        [Given(@"dictum vulputate lectus consequat")]
        public void GivenInEleifendExUt()
        {
           AutomationStub.DoStep();
        }

        [Then(@"(\d+) lobortis diam (\d+) ut")]
        public void ThenDonecMiInViverra(int p0, int p1, Table p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

    }
}
