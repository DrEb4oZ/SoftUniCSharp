using System;

namespace _01.BackToThePast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());
            int yearCount = 18;
            double spentMoney = 0;

            for (int i = 1800; i <= yearToLive; i++)
            {
                if (i % 2 == 0)
                {
                    spentMoney += 12000;
                }
                else
                {
                    spentMoney += 12000 + 50 * yearCount;
                }
                yearCount++;
            }
            double moneyLeftOrNeeded = Math.Abs(inheritedMoney - spentMoney);
            if (spentMoney <= inheritedMoney)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {moneyLeftOrNeeded:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {moneyLeftOrNeeded:f2} dollars to survive.");
            }
        }
    }
}
