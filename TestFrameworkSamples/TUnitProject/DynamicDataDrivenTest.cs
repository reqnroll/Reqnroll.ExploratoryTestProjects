namespace TUnitProject;

public class DynamicDataDrivenTest
{
    [Test]
    [MethodDataSource(nameof(DynamicDataDriven1DataSource))]
    public void DynamicDataDriven1(string strParam, int intParam)
    {

    }

    public static IEnumerable<(string strParam, int intParam)> DynamicDataDriven1DataSource()
    {
        yield return ("foo", 42);
        yield return ("bar", 43);
        yield return ("baz", 44);
    }

    [Test]
    [DynamicDataDriven2DataGenerator]
    public void DynamicDataDriven2(string strParam, int intParam)
    {

    }

    public class DynamicDataDriven2DataGenerator : DataSourceGeneratorAttribute<string, int>
    {
        public override IEnumerable<Func<(string, int)>> GenerateDataSources(DataGeneratorMetadata dataGeneratorMetadata)
        {
            yield return () => ("foo", 42);
            yield return () => ("bar", 43);
            yield return () => ("baz", 44);
        }
    }
}
