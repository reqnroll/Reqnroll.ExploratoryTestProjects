using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTest4Project;

[TestClass]
public class BasicTest
{
    [TestMethod]
    public void TestMethod1()
    {
    }

    [TestMethod]
    [DisplayName("Test Method 2")]
    public void TestMethod2()
    {
    }
}