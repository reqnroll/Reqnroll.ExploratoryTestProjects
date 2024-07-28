using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace NUnitProject;

[TestFixture]
public class DynamicDataDrivenTest
{
    public static IEnumerable<object[]> DynamicDataDriven1_DataProvider()
    {
        return new[]
        {
            new object[] { "foo", 42 },
            new object[] { "bar", 43 },
            new object[] { "baz", 44 },
        };
    }

    [Test]
    [TestCaseSource(nameof(DynamicDataDriven1_DataProvider))]
    public void DynamicDataDriven1(string strParam, int intParam)
    {

    }

    public static IEnumerable<object[]> DynamicDataDriven2_DataProvider(string dataProviderParam)
    {
        return new[]
        {
            new object[] { "foo", 42 },
            new object[] { "bar", 43 },
            new object[] { "baz", 44 },
        };
    }

    [Test]
    [TestCaseSource(nameof(DynamicDataDriven2_DataProvider), methodParams: new object?[] { "provider param 1" })]
    public void DynamicDataDriven2(string strParam, int intParam)
    {

    }
}
