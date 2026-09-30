using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class LiberoLoremUtMaurisSteps
    {
        [Then(@"ad per dui Curabitur")]
        public void ThenInEfficiturJustoA()
        {
           AutomationStub.DoStep();
        }

        [When(@"(\d+) erat Duis")]
        public void WhenMassaMolestieElitVenenatis(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"egestas porta tortor")]
        public void GivenCongueAccumsanCurabiturFelis(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"""(.*)"" porta sit fermentum et")]
        public void WhenCommodoCommodoDiamTincidunt(string p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"sit enim risus")]
        public void WhenNonBlanditAuctorAc(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"risus ultricies ac")]
        public void GivenBlanditPorttitorOrciProin()
        {
           AutomationStub.DoStep();
        }

        [When(@"iaculis ipsum Etiam a (\d+)")]
        public void WhenVitaeEnimMassaHendrerit(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"felis ut Maecenas")]
        public void ThenJustoScelerisqueUrnaClass()
        {
           AutomationStub.DoStep();
        }

    }
}
