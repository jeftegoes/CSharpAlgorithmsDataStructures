using System;
using NUnit.Framework;

namespace Business.Test
{
    [TestFixture]
    public class DegreeConverterTest
    {
        private readonly DegreeConverter _degreeConverter;

        public DegreeConverterTest()
        {
            _degreeConverter = new DegreeConverter();
        }

        [Test]
        public void ToFahrenheit_29d4_Returns84p92()
        {
            var temp = _degreeConverter.ToFahrenheit(celsius:29.4d);
            
            temp = Math.Round(temp, 2);

            Assert.That(temp, Is.EqualTo(expected:84.92d));
        }

        [Test]
        public void ToCelsius_84p92_Returns29p4()
        {
            var temp = _degreeConverter.ToCelsius(fahrenheit:84.92d);

            temp = Math.Round(temp, 2);

            Assert.That(temp, Is.EqualTo(expected:29.4d));
        }
    }
}
