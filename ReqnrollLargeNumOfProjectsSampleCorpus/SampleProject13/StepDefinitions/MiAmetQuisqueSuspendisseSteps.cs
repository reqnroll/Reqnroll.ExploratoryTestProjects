using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class MiAmetQuisqueSuspendisseSteps
    {
        [Given(@"eros justo ""(.*)"" Suspendisse dapibus")]
        public void GivenEtTempusMollisMolestie(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"quis felis nunc")]
        public void ThenAcTemporSemPer()
        {
           AutomationStub.DoStep();
        }

        [Given(@"ante pellentesque varius")]
        public void GivenVitaeQuisqueMaurisEx()
        {
           AutomationStub.DoStep();
        }

        [Then(@"quam vulputate laoreet Class")]
        public void ThenAugueNuncAptentVel()
        {
           AutomationStub.DoStep();
        }

        [Then(@"Donec orci eu (\d+) torquent")]
        public void ThenEfficiturScelerisqueMaecenasOdio(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"suscipit non enim")]
        public void ThenSuspendisseLaoreetTinciduntNec()
        {
           AutomationStub.DoStep();
        }

    }
}
