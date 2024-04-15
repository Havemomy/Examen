using Joker.Views;

namespace TestProject1;


public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        double v = 15;
        double expected = 3.06;
        UnitTestClass test = new UnitTestClass();
        double actual = test.CalcT(v);
        Assert.Equals(expected, actual);
    }

    [Test]
    public void Test2()
    {
        double v = 15;
        double expected = 4.06;
        UnitTestClass test = new UnitTestClass();
        double actual = test.CalcT(v);
        Assert.Equals(expected, actual);
    }
}

