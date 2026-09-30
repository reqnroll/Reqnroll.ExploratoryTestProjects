using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class EuPhasellusTristiqueEleifendSteps
    {
        [When(@"(\d+) ad Sed")]
        public void WhenSemConsequatJustoQuisque(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"dignissim Sed Nunc sed")]
        public void GivenAliquamSitDictumSed()
        {
           AutomationStub.DoStep();
        }

        [Then(@"luctus Proin massa tempor Curabitur")]
        public void ThenLoremPhasellusDolorTorquent()
        {
           AutomationStub.DoStep();
        }

        [When(@"bibendum bibendum lobortis (\d+)")]
        public void WhenDapibusRisusInAuctor(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"diam sapien Suspendisse ""(.*)"" justo")]
        public void GivenAmetPerDiamPhasellus(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"In pretium ligula consequat orci")]
        public void WhenSedAmetNecSit()
        {
           AutomationStub.DoStep();
        }

    }
}
