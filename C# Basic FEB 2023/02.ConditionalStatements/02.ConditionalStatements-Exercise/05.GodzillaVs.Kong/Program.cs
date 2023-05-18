using System;

namespace _05.GodzillaVs.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double filmBudget = double.Parse(Console.ReadLine());
            int filmExtraPerson = int.Parse(Console.ReadLine());
            double costumePricePerExtraPerson = double.Parse(Console.ReadLine());
            double filmDecorPrice = filmBudget * 0.10;
            double costumeSum = costumePricePerExtraPerson * filmExtraPerson;
            if (filmExtraPerson > 150)
            {
                costumeSum = costumeSum * 0.90;
            }
            double totalCost = filmDecorPrice + costumeSum;
            if (filmBudget >= totalCost)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {filmBudget - totalCost:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalCost - filmBudget:f2} leva more.");
            }    
        }
    }
}
