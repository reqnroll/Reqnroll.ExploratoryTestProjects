namespace TUnitProject;

public class DataDrivenTest
{
    [Test]
    [Arguments("foo", 42)]
    [Arguments("bar", 43)]
    [Arguments("baz", 44)]
    public void DataDriven1(string strParam, int intParam)
    {

    }

    [Test]
    [DisplayName("Data Driven 2")]
    [Arguments("foo", 42)]
    [Arguments("bar", 43)]
    [Arguments("baz", 44)]
    public void DataDriven2(string strParam, int intParam)
    {

    }
}