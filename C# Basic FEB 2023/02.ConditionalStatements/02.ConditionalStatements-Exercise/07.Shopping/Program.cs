using System;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int GPU = int.Parse(Console.ReadLine());
            int CPU = int.Parse(Console.ReadLine());
            int RAM = int.Parse(Console.ReadLine());
            int GPUPrice = GPU * 250;
            double CPUPrice = GPUPrice * 0.35 * CPU;
            double RAMPrice = GPUPrice * 0.10 * RAM;
            double totalCost = GPUPrice + CPUPrice + RAMPrice;
            if (GPU > CPU)
            {
                totalCost = totalCost * 0.85;
            }
            if (budget >= totalCost)
            {
                Console.WriteLine($"You have {budget - totalCost:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalCost - budget:f2} leva more!");
            }
        }
    }
}
