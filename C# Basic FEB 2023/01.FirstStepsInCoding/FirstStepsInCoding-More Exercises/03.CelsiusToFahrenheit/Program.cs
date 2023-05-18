using System;

namespace _03.CelsiusToFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5.0) + 32;

            Console.WriteLine($"{fahrenheit:f2}");
        }
    }
}
