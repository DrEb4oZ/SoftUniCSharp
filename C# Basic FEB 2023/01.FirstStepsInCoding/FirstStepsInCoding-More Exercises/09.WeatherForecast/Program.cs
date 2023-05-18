using System;

namespace _09.WeatherForecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string weather = Console.ReadLine();

            string result;

            if (weather == "sunny")
                Console.WriteLine("It's warm outside!");
            else
                Console.WriteLine("It's cold outside!");
        }
    }
}
