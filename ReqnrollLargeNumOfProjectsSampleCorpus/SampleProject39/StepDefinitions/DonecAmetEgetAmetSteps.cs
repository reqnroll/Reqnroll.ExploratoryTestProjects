using System;
using Reqnroll;
namespace DeveroomSample.StepDefinitions
{
    [Binding]
    public class DonecAmetEgetAmetSteps
    {
        [Then(@"ante sapien nec")]
        public void ThenQuisqueVolutpatCurabiturLectus()
        {
           AutomationStub.DoStep();
        }

        [Given(@"(\d+) molestie odio (\d+) dolor")]
        public void GivenVulputateLacusDonecDonec(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Given(@"orci eu augue (\d+)")]
        public void GivenFelisMassaLectusEnim(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [Then(@"cursus tincidunt (\d+) (\d+) Morbi")]
        public void ThenHimenaeosFaucibusNecElit(int p0, int p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"mauris eu Sed")]
        public void ThenExLoremIpsumPorta(Table p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"Lorem eget leo (\d+) Donec")]
        public void WhenSemLeoPulvinarMorbi(int p0)
        {
           AutomationStub.DoStep(p0);
        }

        [When(@"faucibus (\d+) sociosqu")]
        public void WhenMassaSitDiamIpsum(int p0, Table p1)
        {
           AutomationStub.DoStep(p0, p1);
        }

        [Then(@"vitae Maecenas non dictum purus")]
        public void ThenNequeNecIpsumSuspendisse()
        {
           AutomationStub.DoStep();
        }

    }
}
