using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class ClassSemLoremPortaSteps
    {
        [Then(@"tellus taciti Aliquam nunc (\d+)")]
        public void ThenCommodoEuEtiamElementum(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"""(.*)"" fermentum vulputate sagittis lobortis")]
        public void GivenElitIntegerConubiaVitae(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"vitae suscipit Phasellus (\d+)")]
        public void ThenInTemporTellusSapien(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"mi cursus molestie urna")]
        public void GivenSitIdNecAt()
        {
           AutomationStub.DoStep();
        }

        [Then(@"in In id")]
        public void ThenLigulaErosAtCongue(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"nec scelerisque porta (\d+) iaculis")]
        public void ThenMollisInMassaDiam(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"dignissim Sed Nunc sed")]
        public void GivenDuiAugueAugueLaoreet()
        {
           AutomationStub.DoStep();
        }

        [Then(@"(\d+) dolor fermentum vel tempus")]
        public void ThenNullaSitEuismodSit(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

    }
}
