using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());
            double dogFoodSum = dogFood * 2.50;
            int catFoodSum = catFood * 4;
            double endSum = dogFoodSum + catFoodSum;
            Console.WriteLine($"{endSum} lv.");
        }
    }
}
