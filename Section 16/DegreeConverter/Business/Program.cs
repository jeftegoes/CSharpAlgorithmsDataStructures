using System;

namespace Business
{
    class Program
    {
        static void Main(string[] args)
        {
            var degreeConverter = new DegreeConverter();

            var tempCelcius = 29.4d;

            var tempFahrenheitConverted = degreeConverter.ToFahrenheit(tempCelcius);

            Console.WriteLine($"{tempCelcius}º Celsius to Fahrenheit {tempFahrenheitConverted:0.##}");

            var tempFahrenheit = 84.92d;

            var tempCelsiusConverted = degreeConverter.ToCelsius(tempFahrenheit);

            Console.WriteLine($"{tempFahrenheit} Fahrenheit to {tempCelsiusConverted:0.##}º");
        }
    }
}
