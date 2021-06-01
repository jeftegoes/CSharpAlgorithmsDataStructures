using System;
using NUnit.Framework;

namespace Business.Tests
{
    [TestFixture]
    public class RomanNumeralTests
    {
        [TestCase(1, "I")]
        [TestCase(5, "V")]
        [TestCase(2, "II")]
        [TestCase(4, "IV")]
        public void Parse(int expected, string roman)
        {
            Assert.AreEqual(expected, RomanNumeral.Parse(roman));
        }
    }
}
