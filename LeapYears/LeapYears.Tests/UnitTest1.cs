using NFluent;
using NUnit.Framework;

namespace LeapYears.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_return_true_when_isLeapYears_for_2000()
        {
            var isLeapYears = IsLeapYears(2000);

            Check.That(isLeapYears).IsTrue();
        }
        
        [Test]
        public void Should_return_true_when_isLeapYears_for_1700()
        {
            var isLeapYears = IsLeapYears(1700);

            Check.That(isLeapYears).IsFalse();
        }


        private bool IsLeapYears(int years)
        {
            return true;
        }
    }
}