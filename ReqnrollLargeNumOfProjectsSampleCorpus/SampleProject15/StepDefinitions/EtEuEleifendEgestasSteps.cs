using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class EtEuEleifendEgestasSteps
    {
        [Then(@"urna (\d+) suscipit")]
        public void ThenEgestasIntegerMassaCongue(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"commodo eget magna molestie")]
        public void WhenElementumLoremErosJusto(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"risus ultricies ac")]
        public void GivenAmetSuspendisseDapibusCondimentum()
        {
           AutomationStub.DoStep();
        }

        [When(@"lacus ""(.*)"" (\d+)")]
        public void WhenConsequatSapienNecBlandit(string p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"(\d+) nisi odio ""(.*)""")]
        public void WhenTortorRhoncusAcMolestie(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"a (\d+) Phasellus amet")]
        public void WhenQuisqueDignissimTemporDignissim(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"viverra feugiat aptent vulputate non")]
        public void WhenIpsumRhoncusNullaEt()
        {
           AutomationStub.DoStep();
        }

        [Given(@"sollicitudin varius cursus")]
        public void GivenSuspendisseCommodoAcMalesuada()
        {
           AutomationStub.DoStep();
        }

    }
}
