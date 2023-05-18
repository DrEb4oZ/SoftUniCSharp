using System;

namespace _05.Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayCount = int.Parse(Console.ReadLine());
            int foodLeftInKg = int.Parse(Console.ReadLine());
            double dogFoodConsumationKg = double.Parse(Console.ReadLine());
            double catFoodConsumationKg = double.Parse(Console.ReadLine());
            double turtleFoodConsumationGrams = double.Parse(Console.ReadLine());
            double totalFoodNeed = dogFoodConsumationKg * dayCount + catFoodConsumationKg * dayCount + (turtleFoodConsumationGrams / 1000.0 * dayCount);
            if (foodLeftInKg >= totalFoodNeed)
            {
                Console.WriteLine($"{Math.Floor(foodLeftInKg - totalFoodNeed)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFoodNeed - foodLeftInKg)} more kilos of food are needed.");
            }
        }
    }
}
