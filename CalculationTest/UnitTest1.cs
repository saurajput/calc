using Calculation;

namespace CalculationTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Calc calc = new();
            int result = calc.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void Test2()
        {
            Calc calc = new();
            int result = calc.Add(-2, 3);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void Test3()
        {
            Calc calc = new();
            int result = calc.Add(2, -3);
            Assert.That(result, Is.EqualTo(-1));
        }
    }
}