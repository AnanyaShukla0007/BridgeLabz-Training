using NUnit.Framework;
using System.IO;

[TestFixture]
public class FileProcessorTests
{
    string path = "test.txt";

    [Test]
    public void WriteAndRead_WorksCorrectly()
    {
        FileProcessor fp = new FileProcessor();
        fp.WriteToFile(path, "Hello");

        Assert.IsTrue(File.Exists(path));
        Assert.AreEqual("Hello", fp.ReadFromFile(path));
    }
}
