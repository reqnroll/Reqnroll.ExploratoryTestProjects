using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class NonQuisqueEuOrciSteps
    {
        [Given(@"taciti mollis blandit egestas eu")]
        public void GivenRisusTristiqueEgetMaecenas(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"tempus bibendum ultricies dictum")]
        public void GivenSemMattisCursusMagna(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"dignissim Sed Nunc sed")]
        public void GivenBibendumSitPerA()
        {
           AutomationStub.DoStep();
        }

        [When(@"(\d+) pulvinar at Integer ""(.*)""")]
        public void WhenQuamVitaeInceptosAmet(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"lorem hendrerit Integer Donec")]
        public void WhenEuQuisqueExAliquet()
        {
           AutomationStub.DoStep();
        }

        [When(@"""(.*)"" felis quam ""(.*)""")]
        public void WhenUltriciesMattisLacusTortor(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"In ligula vitae")]
        public void WhenMollisVariusVolutpatEgestas()
        {
           AutomationStub.DoStep();
        }

        [Given(@"Morbi lobortis Suspendisse (\d+)")]
        public void GivenScelerisqueAugueElementumId(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

    }
}
