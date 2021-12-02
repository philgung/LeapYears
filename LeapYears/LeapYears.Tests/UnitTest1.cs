using NFluent;
using NUnit.Framework;

namespace LeapYears.Tests
{
    public class Tests
    {
        [Test]
        public void Should_return_true_when_year_was_divisible_by_400()
        {
            var isLeapYears = IsLeapYears(2000);

            Check.That(isLeapYears).IsTrue();
        }
        
        [TestCase(1700)]
        [TestCase(1800)]
        [TestCase(1900)]
        [TestCase(2100)]
        public void Should_return_false_when_year_was_divisible_by_100_but_not_by_400(int years)
        {
            var isLeapYears = IsLeapYears(years);

            Check.That(isLeapYears).IsFalse();
        }

        private bool IsLeapYears(int years)
        {
            if (IsDivisibleBy(100, years) && !IsDivisibleBy(400, years))
            {
                return false;
            }
            return true;
        }

        private static bool IsDivisibleBy(int divider, int years)
        {
            return years % divider == 0;
        }
    }
}