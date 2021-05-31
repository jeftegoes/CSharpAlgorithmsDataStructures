using System;
using NUnit.Framework;

namespace Business.Test
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase("Fizz", 3)]
        [TestCase("Fizz", 6)]
        [TestCase("Buzz", 5)]
        [TestCase("Buzz", 10)]
        [TestCase("FizzBuzz", 15)]
        [TestCase("FizzBuzz", 30)]
        [TestCase("", 7)]
        public void Ask_Return(string expected, int number)
        {
            Assert.AreEqual(expected, FizzBuzz.Ask(number));
        }
    }
}
