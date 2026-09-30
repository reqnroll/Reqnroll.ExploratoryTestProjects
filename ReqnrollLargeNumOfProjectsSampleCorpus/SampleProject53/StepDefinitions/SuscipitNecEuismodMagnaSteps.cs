using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class SuscipitNecEuismodMagnaSteps
    {
        [When(@"condimentum egestas neque eu")]
        public void WhenMolestieCursusTellusId(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"""(.*)"" felis quam ""(.*)""")]
        public void WhenMolestieLuctusCommodoA(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"Integer ""(.*)"" Ut orci ""(.*)""")]
        public void GivenAuctorFelisNullaEt(string p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"(\d+) massa sit")]
        public void ThenRisusNullaCurabiturCurabitur(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"euismod (\d+) lorem Curabitur")]
        public void WhenAugueLuctusMagnaEget(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"sollicitudin varius cursus")]
        public void GivenAmetEuLiberoEnim()
        {
           AutomationStub.DoStep();
        }

    }
}
