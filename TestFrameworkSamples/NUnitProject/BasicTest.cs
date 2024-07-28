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
}