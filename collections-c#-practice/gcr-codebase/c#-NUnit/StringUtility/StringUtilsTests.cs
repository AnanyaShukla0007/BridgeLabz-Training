using NUnit.Framework;

[TestFixture]
public class StringUtilsTests
{
    StringUtils utils;

    [SetUp]
    public void Init()
    {
        utils = new StringUtils();
    }

    [Test]
    public void Reverse_WorksCorrectly()
    {
        Assert.AreEqual("olleh", utils.Reverse("hello"));
    }

    [Test]
    public void IsPalindrome_ReturnsTrue()
    {
        Assert.IsTrue(utils.IsPalindrome("madam"));
    }
}
