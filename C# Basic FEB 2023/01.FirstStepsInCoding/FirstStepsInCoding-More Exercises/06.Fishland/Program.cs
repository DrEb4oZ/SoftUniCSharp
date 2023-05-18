using System;

namespace _06.Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());
            double bonitoAmountKG = double.Parse(Console.ReadLine());
            double safridAmountKG = double.Parse(Console.ReadLine());
            int clamAmountKG = int.Parse(Console.ReadLine());

            double bonitoPrice = mackerelPrice * 1.60;
            double safridPrice = spratPrice * 1.80;

            double sum = bonitoAmountKG * bonitoPrice + safridAmountKG * safridPrice + clamAmountKG * 7.50;

            Console.WriteLine($"{sum:f2}");

        }
    }
}
