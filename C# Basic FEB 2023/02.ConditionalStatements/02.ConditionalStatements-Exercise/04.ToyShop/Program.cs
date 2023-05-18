using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int bearCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());
            double totalPrice = puzzleCount * 2.60 + dollCount * 3 + bearCount * 4.10 + minionCount * 8.2 + truckCount * 2;
            int totalToys = puzzleCount + dollCount + bearCount + minionCount + truckCount;
            if (totalToys >= 50)
            {
                totalPrice = 0.75 * totalPrice;
            }
            double profit = totalPrice * 0.90;
            if (profit >= vacationPrice)
            {
                Console.WriteLine($"Yes! {profit - vacationPrice:f2} lv left.");
            }
            else
                Console.WriteLine($"Not enough money! {vacationPrice - profit:f2} lv needed.");
        }
    }
}
