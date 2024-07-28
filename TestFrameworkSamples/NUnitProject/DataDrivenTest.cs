using System;
using NUnit.Framework;

namespace NUnitProject;

[TestFixture]
public class DataDrivenTest
{
    [Test]
    [TestCase("foo", 42)]
    [TestCase("bar", 43)]
    [TestCase("baz", 44)]
    public void DataDriven1(string strParam, int intParam)
    {

    }

    // not working with VS test explorer
    [Test(Description = "Data Driven 2")]
    [TestCase("foo", 42, TestName = "foo with 42")]
    [TestCase("bar", 43, TestName = "bar with 43")]
    [TestCase("baz", 44, TestName = "baz with 44")]
    public void DataDriven2(string strParam, int intParam)
    {

    }

    // description not displayed: VS Test Explorer, ReSharper
    [Test(Description = "Data Driven 2")]
    [TestCase("foo", 42, Description = "foo with 42")]
    [TestCase("bar", 43, Description = "bar with 43")]
    [TestCase("baz", 44, Description = "baz with 44")]
    public void DataDriven3(string strParam, int intParam)
    {

    }
}
