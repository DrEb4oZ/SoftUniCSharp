using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyForVacation = double.Parse(Console.ReadLine());
            double presentMoney = double.Parse(Console.ReadLine());
            string spendOrSave = Console.ReadLine();
            int daySpendCount = 0;
            int totalDaysCount = 0;
            bool daySpend5 = false;
            while (presentMoney < moneyForVacation && !daySpend5)
            {
                totalDaysCount++;
                if (spendOrSave == "spend")
                {
                    double spendMoney = double.Parse(Console.ReadLine());
                    daySpendCount++;
                    presentMoney -= spendMoney;
                    if (daySpendCount == 5)
                    {
                        daySpend5 = true;
                        continue;
                    }
                }
                else if (spendOrSave == "save")
                {
                    double saveMoney = double.Parse(Console.ReadLine());
                    presentMoney += saveMoney;
                    daySpendCount = 0;
                }
                if (presentMoney < 0)
                {
                    presentMoney = 0;
                }
                spendOrSave = Console.ReadLine();
            }
            if (daySpend5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{totalDaysCount}");
            }
            else
            {
                Console.WriteLine($"You saved the money for {totalDaysCount} days.");
            }
        }
    }
}
