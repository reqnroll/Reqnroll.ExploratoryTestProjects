using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class FelisEfficiturMolestieEnimSteps
    {
        [Given(@"inceptos mi tempor")]
        public void GivenSedEratEtSem()
        {
           AutomationStub.DoStep();
        }

        [Then(@"felis ut Maecenas")]
        public void ThenDictumVestibulumEtAliquam()
        {
           AutomationStub.DoStep();
        }

        [When(@"bibendum Phasellus tellus ante")]
        public void WhenPulvinarAtDiamNec(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"""(.*)"" porta sit fermentum et")]
        public void WhenDolorInEtEget(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"ad per dui Curabitur")]
        public void ThenLiberoTristiqueMagnaUt()
        {
           AutomationStub.DoStep();
        }

        [Given(@"sem per vitae")]
        public void GivenLiberoDapibusLaoreetNostra()
        {
           AutomationStub.DoStep();
        }

    }
}
