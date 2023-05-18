using System;

namespace _03.Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemumCount = int.Parse(Console.ReadLine());
            int roseCount = int.Parse(Console.ReadLine());
            int tulipCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char isItHollyday = char.Parse(Console.ReadLine());
            double totalCost = 0;
            if (season == "Spring" || season == "Summer")
            {
                totalCost = chrysanthemumCount * 2 + roseCount * 4.1 + tulipCount * 2.50;
                if (tulipCount > 7 && season == "Spring")
                {
                    totalCost = totalCost * 0.95;
                }
                if (chrysanthemumCount + roseCount + tulipCount > 20)
                {
                        totalCost = totalCost * 0.8;
                }
            }
            else if (season == "Autumn" || season == "Winter")
            {
                totalCost = chrysanthemumCount * 3.75 + roseCount * 4.5 + tulipCount * 4.15;
                if (roseCount >= 10 && season == "Winter")
                {
                    totalCost = totalCost * 0.90;
                }
                if (chrysanthemumCount + roseCount + tulipCount > 20)
                {
                        totalCost = totalCost * 0.8;
                }
            }
            if (isItHollyday == 'Y')
            {
                Console.WriteLine($"{totalCost * 1.15 + 2:f2}");
            }
            else if (isItHollyday == 'N')
            {
                Console.WriteLine($"{totalCost + 2:f2}");
            }
        }
    }
}
