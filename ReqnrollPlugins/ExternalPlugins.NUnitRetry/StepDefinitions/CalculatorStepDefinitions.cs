using NUnit.Framework;

namespace ExternalPlugins.NUnitRetry.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        public static int RetryCount = 0;

        [When("I increment the retry count")]
        public void WhenIIncrementTheRetryCount()
        {
            RetryCount++;
            if (RetryCount < 3)
                Assert.Fail("Simulate a failure");
        }

        [Then("the result should be {int}")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(result, RetryCount);
        }
    }
}
