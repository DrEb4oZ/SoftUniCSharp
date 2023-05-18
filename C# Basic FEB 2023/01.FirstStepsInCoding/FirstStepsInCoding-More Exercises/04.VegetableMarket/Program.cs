using System;

namespace _04.VegetableMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int vegetableAmountKG = int.Parse(Console.ReadLine());
            int fruitAmountKG = int.Parse(Console.ReadLine());

            double sum = ((vegetablePrice * vegetableAmountKG) + (fruitPrice * fruitAmountKG)) / 1.94;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
