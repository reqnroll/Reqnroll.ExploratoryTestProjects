using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class PretiumDonecEuSemSteps
    {
        [Then(@"euismod Fusce torquent malesuada")]
        public void ThenDolorDignissimTempusDictum()
        {
           AutomationStub.DoStep();
        }

        [Then(@"in pretium consequat")]
        public void ThenFelisVenenatisEtNon()
        {
           AutomationStub.DoStep();
        }

        [Given(@"(\d+) eros suscipit diam sodales")]
        public void GivenSemPortaPerOdio(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"""(.*)"" nunc Praesent auctor")]
        public void ThenEuConsecteturAugueDonec(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"venenatis amet id in")]
        public void ThenDignissimEuAAt()
        {
           AutomationStub.DoStep();
        }

        [Then(@"conubia viverra in in")]
        public void ThenInInScelerisqueVel()
        {
           AutomationStub.DoStep();
        }

    }
}
