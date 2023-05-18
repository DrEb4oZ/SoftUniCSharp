using System;

namespace _06.FlowerShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magnoliaCount = int.Parse(Console.ReadLine());
            int hyacinthCount = int.Parse(Console.ReadLine());
            int roseCount = int.Parse(Console.ReadLine());
            int cactusCount = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());
            double totalIncome = 0.95 * (magnoliaCount * 3.25 + hyacinthCount * 4 + roseCount * 3.50 + cactusCount * 8);
            if (totalIncome >= giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(totalIncome - giftPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - totalIncome)} leva.");
            }
        }
    }
}
