using System;

namespace _10.WeatherForecast_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperature = double.Parse(Console.ReadLine());

            if (26.00 <= temperature && temperature <= 35.00)
                Console.WriteLine("Hot");
            else if (20.1 <= temperature && temperature <= 25.9)
                Console.WriteLine("Warm");
            else if (15 <= temperature && temperature <= 20)
                Console.WriteLine("Mild");
            else if (12 <= temperature && temperature <= 14.9)
                Console.WriteLine("Cool");
            else if (5 <= temperature && temperature <= 11.9)
                Console.WriteLine("Cold");
            else
                Console.WriteLine("unknown");
        }
    }
}
