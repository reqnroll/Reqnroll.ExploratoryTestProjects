using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class NullaVestibulumDapibusEgestasSteps
    {
        [Given(@"sollicitudin varius cursus")]
        public void GivenVelIntegerNisiMagna()
        {
           AutomationStub.DoStep();
        }

        [Given(@"nunc augue felis cursus")]
        public void GivenIdLoremPharetraLacus(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"ad finibus augue")]
        public void ThenGravidaFelisDapibusVitae()
        {
           AutomationStub.DoStep();
        }

        [Then(@"mauris eu Sed")]
        public void ThenHimenaeosExDonecBlandit(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Given(@"(\d+) eros felis at lorem")]
        public void GivenALoremFelisConsequat(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [When(@"vel sed dolor vestibulum")]
        public void WhenInDignissimPhasellusId()
        {
           AutomationStub.DoStep();
        }

        [Then(@"In vitae (\d+) ""(.*)""")]
        public void ThenLitoraSuspendisseTacitiIn(int p0, string p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"vitae Aliquam Nam commodo")]
        public void ThenMaecenasEuismodNonTristique()
        {
           AutomationStub.DoStep();
        }

    }
}
