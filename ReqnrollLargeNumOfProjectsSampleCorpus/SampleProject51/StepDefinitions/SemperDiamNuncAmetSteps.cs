using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class SemperDiamNuncAmetSteps
    {
        [Given(@"eleifend libero vitae")]
        public void GivenViverraQuisqueNamEnim()
        {
           AutomationStub.DoStep();
        }

        [Given(@"(\d+) felis quis dui")]
        public void GivenLoremAtUtSit(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"quis ipsum erat")]
        public void WhenAmetAliquamPulvinarTempor()
        {
           AutomationStub.DoStep();
        }

        [Given(@"""(.*)"" tempor Phasellus amet")]
        public void GivenNuncLacusTellusNostra(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"""(.*)"" eu id nec")]
        public void GivenSedSapienLeoMattis(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"tincidunt ""(.*)"" vitae")]
        public void WhenVenenatisErosSedLeo(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"nec (\d+) massa molestie")]
        public void WhenVitaeAcLigulaLorem(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"eget in Phasellus urna")]
        public void WhenIdSodalesBibendumAliquet()
        {
           AutomationStub.DoStep();
        }

    }
}
