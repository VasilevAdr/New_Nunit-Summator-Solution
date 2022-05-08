using NUnit.Framework;

namespace Summator.Tests
{
    public class Tests
    {
        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            int result = Summator.Sum(new int [] { 5, 7 });
        Assert.That(result, Is.EqualTo(12));
        }
        [Test]
        public void Test_Sum_OnePossitiveNumber()
        {
            int result = Summator.Sum(new int[] { 5 });
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void Test_Sum_EmptyArray()
        {
            int expected = Summator.Sum(new int[] { });
            Assert.That(expected == 0);
        }
        [Test]
        public void Test_Sum_BigValues()
        {
            int expected = Summator.Sum(new int[] { 2000000000, 2000000000, 2000000000 });
            Assert.AreEqual(expected, 6000000000);
        }
    }
}