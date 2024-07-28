using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTestProject;

[TestClass]
public class DataDrivenTest
{
    [TestMethod]
    [DataRow("foo", 42)]
    [DataRow("bar", 43)]
    [DataRow("baz", 44)]
    public void DataDriven1(string strParam, int intParam)
    {

    }

    [TestMethod("Data Driven 2")]
    [DataRow("foo", 42)]
    [DataRow("bar", 43)]
    [DataRow("baz", 44)]
    public void DataDriven2(string strParam, int intParam)
    {

    }

    [TestMethod("Data Driven 3")]
    [DataRow("foo", 42, DisplayName = "foo with 42")]
    [DataRow("bar", 43, DisplayName = "bar with 43")]
    [DataRow("baz", 44, DisplayName = "baz with 44")]
    public void DataDriven3(string strParam, int intParam)
    {

    }
}
