using System.IO;
using NUnit.Framework;

namespace NUnitProject;

public class AttachmentTest
{

    [Test]
    public void TestWithTxtAttachment()
    {
        TestContext.AddTestAttachment(Path.Combine("..", "..", "..", "..", "sample-txt-attachment.txt"));
    }

    [Test]
    public void TestWithSameAttachment()
    {
        // uses the same attachment as TestWithTxtAttachment
        TestContext.AddTestAttachment(Path.Combine("..", "..", "..", "..", "sample-txt-attachment.txt"));
    }

    [Test]
    public void TestWithAttachmentOfSameName()
    {
        // uses the same attachment as TestWithTxtAttachment
        string sourceFileName = Path.Combine("..", "..", "..", "..", "sample-other-txt-attachment.txt");
        File.Copy(sourceFileName, "sample-txt-attachment.txt", true);
        TestContext.AddTestAttachment("sample-txt-attachment.txt");
    }

    [Test]
    public void TestWithPngAttachment()
    {
        TestContext.AddTestAttachment(Path.Combine("..", "..", "..", "..", "sample-png-attachment.png"));
    }

}