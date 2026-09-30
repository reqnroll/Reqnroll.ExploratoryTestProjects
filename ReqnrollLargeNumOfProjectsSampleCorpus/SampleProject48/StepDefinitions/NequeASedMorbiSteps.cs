using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class NequeASedMorbiSteps
    {
        [Then(@"""(.*)"" (\d+) at (\d+) suscipit")]
        public void ThenLobortisSuspendisseVitaeVenenatis(string p0, int p1, int p2)
        {
           AutomationStub.DoStep(p0, p1, p2);
        }

        [Then(@"vitae suscipit Phasellus (\d+)")]
        public void ThenMollisLoremQuisqueNostra(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"(\d+) dignissim ""(.*)""")]
        public void ThenNullaNecLeoEleifend(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"massa justo lectus pretium Praesent")]
        public void GivenQuamIntegerElitAmet()
        {
           AutomationStub.DoStep();
        }

        [When(@"commodo et conubia")]
        public void WhenUtPulvinarVolutpatOdio()
        {
           AutomationStub.DoStep();
        }

        [Given(@"nunc augue felis cursus")]
        public void GivenSuscipitDignissimInNulla(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
