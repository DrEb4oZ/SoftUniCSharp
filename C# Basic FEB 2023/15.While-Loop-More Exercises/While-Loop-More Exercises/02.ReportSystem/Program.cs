using System;

namespace _02.ReportSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int expectedSalesSum = int.Parse(Console.ReadLine());
            int totalSumCash = 0;
            int totalSumCard = 0;
            bool sumReached = false;
            string valuableItmesPrice = Console.ReadLine();
            int transactionCount = 0, transactionCountCash = 0, transactionCountCard = 0;
            while (valuableItmesPrice != "End" && !sumReached)
            {
                int currentValuableItemsPrice = int.Parse(valuableItmesPrice);
                if (transactionCount % 2 == 0)
                {
                    if (currentValuableItemsPrice > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        totalSumCash += currentValuableItemsPrice;
                        transactionCountCash++;
                    }
                }
                else
                {
                    if (currentValuableItemsPrice < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        totalSumCard += currentValuableItemsPrice;
                        transactionCountCard++;
                    }
                }
                transactionCount++;
                if (totalSumCard + totalSumCash >= expectedSalesSum)
                {
                    sumReached = true;
                }
                else
                {
                    valuableItmesPrice = Console.ReadLine();
                }
            }
            if (sumReached)
            {
                double avarageCashTransactoinPerPerson = (double)totalSumCash / transactionCountCash;
                double avarageCardTransactoinPerPerson = (double)totalSumCard / transactionCountCard;
                Console.WriteLine($"Average CS: {avarageCashTransactoinPerPerson:f2}");
                Console.WriteLine($"Average CC: {avarageCardTransactoinPerPerson:f2}");
            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
