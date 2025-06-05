using System.Security.Cryptography;
using NUnit.Framework;

namespace NUnitProject;
public class BasicTest
{
    [Test]
    public void TestMethod1()
    {
        Assert.Pass();
    }


    // description not displayed: VS Test Explorer, ReSharper
    [Test(Description = "Test Method 2")]
    public void TestMethod2()
    {
    }

    // description not displayed: VS Test Explorer, ReSharper
    [Test]
    [Description("Test Method 3")]
    public void TestMethod3()
    {
    }

    // description is displayed in VS Test Explorer, but ReSharper shows it as a subtest
    [TestCase(TestName = "Test Method 4")]
    public void TestMethod4()
    {
    }
}