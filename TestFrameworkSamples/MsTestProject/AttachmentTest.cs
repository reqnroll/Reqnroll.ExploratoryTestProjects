using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTestProject;

[TestClass]
public class AttachmentTest(TestContext testContext)
{
    public TestContext TestContext { get; set; } = testContext;

    [TestMethod]
    public void TestWithTxtAttachment()
    {
        TestContext.AddResultFile(Path.Combine("..", "..", "..", "..", "sample-txt-attachment.txt"));
    }

    [TestMethod]
    public void TestWithSameAttachment()
    {
        // uses the same attachment as TestWithTxtAttachment
        TestContext.AddResultFile(Path.Combine("..", "..", "..", "..", "sample-txt-attachment.txt"));
    }

    [TestMethod]
    public void TestWithAttachmentOfSameName()
    {
        // uses the same attachment as TestWithTxtAttachment
        string sourceFileName = Path.Combine("..", "..", "..", "..", "sample-other-txt-attachment.txt");
        File.Copy(sourceFileName, "sample-txt-attachment.txt", true);
        TestContext.AddResultFile("sample-txt-attachment.txt");
    }

    [TestMethod]
    public void TestWithPngAttachment()
    {
        TestContext.AddResultFile(Path.Combine("..", "..", "..", "..", "sample-png-attachment.png"));
    }

}