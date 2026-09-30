using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class MaurisSuscipitAdipiscingLeoSteps
    {
        [Then(@"tellus taciti Aliquam nunc (\d+)")]
        public void ThenUltriciesUtVelAugue(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"cursus tincidunt (\d+) (\d+) Morbi")]
        public void ThenGravidaViverraSemA(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"nec (\d+) ""(.*)""")]
        public void ThenImperdietClassSemLorem(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"augue id tristique erat eget")]
        public void GivenPortaCommodoEuEtiam()
        {
           AutomationStub.DoStep();
        }

        [When(@"quis ipsum erat")]
        public void WhenElementumElitIntegerConubia()
        {
           AutomationStub.DoStep();
        }

        [When(@"per mi efficitur Nulla")]
        public void WhenVitaeInTemporTellus(string p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
