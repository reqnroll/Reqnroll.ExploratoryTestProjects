using System;
using Xunit;

namespace XUnitProject;

public class DataDrivenTest
{
    [Theory]
    [InlineData("foo", 42)]
    [InlineData("bar", 43)]
    [InlineData("baz", 44)]
    public void DataDriven1(string strParam, int intParam)
    {

    }

    [Theory(DisplayName = "Data Driven 2")]
    [InlineData("foo", 42)]
    [InlineData("bar", 43)]
    [InlineData("baz", 44)]
    public void DataDriven2(string strParam, int intParam)
    {

    }
}
