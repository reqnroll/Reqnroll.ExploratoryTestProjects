using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTestProject;
[TestClass]
public class BasicTest
{
    [TestMethod]
    public void TestMethod1()
    {
    }

    [TestMethod("Test Method 2")]
    public void TestMethod2()
    {
    }
}