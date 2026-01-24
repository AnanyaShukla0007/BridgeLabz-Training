using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    Calculator calc;

    [SetUp]
    public void Setup()
    {
        calc = new Calculator();
    }

    [Test]
    public void Add_ReturnsCorrectSum()
    {
        Assert.AreEqual(5, calc.Add(2, 3));
    }

    [Test]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => calc.Divide(10, 0));
    }
}
