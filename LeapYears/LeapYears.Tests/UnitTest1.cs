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

        private bool IsLeapYears(int years)
        {
            throw new System.NotImplementedException();
        }
    }
}