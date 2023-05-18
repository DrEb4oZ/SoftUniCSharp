using System;
using System.Transactions;

namespace _02.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonuspoints = 0;
            if (number <= 100)
            {
                bonuspoints = 5;
            }
            else if (number < 1000)
            {
                bonuspoints = 0.2 * number;
            }
            else
            {
                bonuspoints = 0.10 * number;
            }
            if (number % 2 == 0)
            {
                bonuspoints = bonuspoints + 1;
            }
            if (number % 10 == 5)
            {
                bonuspoints = bonuspoints + 2;
            }
            Console.WriteLine(bonuspoints);
            Console.WriteLine(number + bonuspoints);
        }
    }
}
