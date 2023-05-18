using System;

namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bankDeposit = Console.ReadLine();
            double totalMoney = 0;
            while (bankDeposit != "NoMoreMoney")
            {
                double income = double.Parse(bankDeposit);
                if (income < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {income:f2}");
                totalMoney += income;
                bankDeposit = Console.ReadLine();
            }
            Console.WriteLine($"Total: {totalMoney:f2}");
        }
    }
}
