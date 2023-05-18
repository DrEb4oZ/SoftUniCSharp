using System;

namespace _01.Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countDishwasherBottles = int.Parse(Console.ReadLine());
            string countOfDishesAndPots = Console.ReadLine();
            int washingCounter = 1;
            double detergentAmountMl = countDishwasherBottles * 750;
            bool detergentEnough = true;
            int dishCount = 0, potCount = 0;
            while (countOfDishesAndPots != "End")
            {
                int currentCountOfDishesAndPots = int.Parse(countOfDishesAndPots);
                if (washingCounter != 3)
                {
                    //Dieshes
                    detergentAmountMl -= currentCountOfDishesAndPots * 5;
                    dishCount += currentCountOfDishesAndPots;
                }
                else
                {
                    // Pots
                    detergentAmountMl -= currentCountOfDishesAndPots * 15;
                    potCount += currentCountOfDishesAndPots;
                    washingCounter = 0;
                }
                washingCounter++;
                if (detergentAmountMl < 0)
                {
                    detergentEnough = false;
                    break;
                }
                countOfDishesAndPots = Console.ReadLine();
            }
            if (detergentEnough)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishCount} dishes and {potCount} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergentAmountMl} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(detergentAmountMl)} ml. more necessary!");
            }
        }
    }
}
