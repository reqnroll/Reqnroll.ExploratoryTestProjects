using System.Collections.Generic;
using Xunit;

namespace XUnitProject;

public class DynamicDataDrivenTest
{
    public static IEnumerable<object[]> DynamicDataDriven1_DataProvider()
    {
        return
        [
            ["foo", 42],
            ["bar", 43],
            ["baz", 44]
        ];
    }

    [Theory]
    [MemberData(nameof(DynamicDataDriven1_DataProvider))]
    public void DynamicDataDriven1(string strParam, int intParam)
    {
        _ = strParam; // to avoid unused parameter warning
        _ = intParam; // to avoid unused parameter warning
    }

    public static IEnumerable<object[]> DynamicDataDriven2_DataProvider(string dataProviderParam)
    {
        return
        [
            ["foo", 42],
            ["bar", 43],
            ["baz", 44]
        ];
    }

    [Theory]
    [MemberData(nameof(DynamicDataDriven2_DataProvider), "provider param 1")]
    public void DynamicDataDriven2(string strParam, int intParam)
    {
        _ = strParam; // to avoid unused parameter warning
        _ = intParam; // to avoid unused parameter warning
    }
}
