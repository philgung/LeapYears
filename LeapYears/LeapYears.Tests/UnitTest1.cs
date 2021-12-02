using NFluent;
using NUnit.Framework;

namespace LeapYears.Tests
{
    public class Tests
    {
        [Test]
        public void Should_return_true_when_isLeapYears_for_2000()
        {
            var isLeapYears = IsLeapYears(2000);

            Check.That(isLeapYears).IsTrue();
        }
        
        [Test]
        public void Should_return_false_when_isLeapYears_for_1700()
        {
            var isLeapYears = IsLeapYears(1700);

            Check.That(isLeapYears).IsFalse();
        }

        [Test]
        public void Should_return_false_when_isLeapYears_for_1800()
        {
            var isLeapYears = IsLeapYears(1800);

            Check.That(isLeapYears).IsFalse();
        }


        private bool IsLeapYears(int years)
        {
            if (years == 1700)
            {
                return false;
            }
            return true;
        }
    }
}