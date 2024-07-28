using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitProject;

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

    [Theory]
    [MemberData(nameof(DynamicDataDriven1_DataProvider))]
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

    [Theory]
    [MemberData(nameof(DynamicDataDriven2_DataProvider), "provider param 1")]
    public void DynamicDataDriven2(string strParam, int intParam)
    {
    }
}
