namespace TUnitProject;

public class BasicTest
{
    [Test]
    public void TestMethod1()
    {
        Console.WriteLine("This is a basic test");
    }

    [Test]
    [DisplayName("Test Method 2")]
    public void TestMethod2()
    {
    }
}