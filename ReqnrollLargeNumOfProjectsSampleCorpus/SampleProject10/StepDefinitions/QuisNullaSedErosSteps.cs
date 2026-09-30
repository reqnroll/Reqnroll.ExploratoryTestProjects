using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class QuisNullaSedErosSteps
    {
        [Given(@"nunc augue felis cursus")]
        public void GivenMaurisElitAliquetBlandit(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"risus ultricies ac")]
        public void GivenEgetInNisiConubia()
        {
           AutomationStub.DoStep();
        }

        [Given(@"felis nec Suspendisse molestie")]
        public void GivenSedPurusNonVel()
        {
           AutomationStub.DoStep();
        }

        [Given(@"""(.*)"" fermentum vulputate sagittis lobortis")]
        public void GivenPulvinarTristiqueMassaSit(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"ante libero ut")]
        public void ThenEuismodVenenatisAmetPulvinar()
        {
           AutomationStub.DoStep();
        }

        [Given(@"taciti mollis blandit egestas eu")]
        public void GivenAmetTortorCurabiturEu(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

    }
}
