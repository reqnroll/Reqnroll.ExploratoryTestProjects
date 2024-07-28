using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTestProject;

[TestClass]
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

    [TestMethod]
    [DynamicData(nameof(DynamicDataDriven1_DataProvider), DynamicDataSourceType.Method)]
    public void DynamicDataDriven1(string strParam, int intParam)
    {

    }

    public static IEnumerable<object[]> DynamicDataDriven2_DataProvider()
    {
        return new[]
        {
            new object[] { "foo", 42, "foo with 42" },
            new object[] { "bar", 43, "bar with 43" },
            new object[] { "baz", 44, "baz with 44" },
        };
    }

    public static string GetTestDisplayNames(MethodInfo methodInfo, object[] values)
    {
        var displayName = values.Last()?.ToString() ?? "";
        return $"{displayName} ({string.Join(",", values.SkipLast(1))})";
    }

    [TestMethod]
    [DynamicData(
        nameof(DynamicDataDriven2_DataProvider), DynamicDataSourceType.Method,
        DynamicDataDisplayName = nameof(GetTestDisplayNames))]
    public void DynamicDataDriven2(string strParam, int intParam, string _displayName)
    {

    }
}
