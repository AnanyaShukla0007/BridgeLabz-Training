using NUnit.Framework;

[TestFixture]
public class NumberUtilsTests
{
    [TestCase(2, true)]
    [TestCase(7, false)]
    [TestCase(4, true)]
    public void IsEven_TestMultipleValues(int input, bool expected)
    {
        NumberUtils utils = new NumberUtils();
        Assert.AreEqual(expected, utils.IsEven(input));
    }
}
