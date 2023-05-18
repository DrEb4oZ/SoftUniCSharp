using System;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;
            if (flowerType == "Roses")
            {
                if (flowerCount > 80)
                {
                    price = 5 * 0.90;
                }
                else
                {
                    price = 5;
                }
            }
            else if (flowerType == "Dahlias")
            {
                if (flowerCount > 90)
                {
                    price = 3.8 * 0.85;
                }
                else
                {
                    price = 3.80;
                }
            }
            else if (flowerType == "Tulips")
            {
                if (flowerCount > 80)
                {
                    price = 2.8 * 0.85;
                }
                else
                {
                    price = 2.80;
                }
            }
            else if (flowerType == "Narcissus")
            {
                if (flowerCount < 120)
                {
                    price = 3 * 1.15;
                }
                else
                {
                    price = 3;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                if (flowerCount < 80)
                {
                    price = 2.5 * 1.2;
                }
                else
                {
                    price = 2.5;
                }
            }
            double finalPrice = price * flowerCount;
            if (finalPrice <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {budget - finalPrice:f2} leva left.");
            }
            else if (finalPrice > budget)
            {
                Console.WriteLine($"Not enough money, you need {finalPrice - budget:f2} leva more.");
            }
        }
    }
}
