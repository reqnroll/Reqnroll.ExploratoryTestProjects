using Xunit;

namespace XUnit3Project;

public class DataDrivenTest
{
    [Theory]
    [InlineData("foo", 42)]
    [InlineData("bar", 43)]
    [InlineData("baz", 44)]
    public void DataDriven1(string strParam, int intParam)
    {
        _ = strParam; // to avoid unused parameter warning
        _ = intParam; // to avoid unused parameter warning
    }

    [Theory(DisplayName = "Data Driven 2")]
    [InlineData("foo", 42)]
    [InlineData("bar", 43)]
    [InlineData("baz", 44)]
    public void DataDriven2(string strParam, int intParam)
    {
        _ = strParam; // to avoid unused parameter warning
        _ = intParam; // to avoid unused parameter warning
    }
}
