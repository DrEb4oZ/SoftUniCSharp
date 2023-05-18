using System;
using System.Transactions;

namespace _01.MatchTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine();
            int peopleCount = int.Parse(Console.ReadLine());
            double transportExpenses = 0;
            if (peopleCount <= 4)
            {
                transportExpenses = budget * 0.75;
            }
            else if (peopleCount <= 9)
            {
                transportExpenses = budget * 0.60;
            }
            else if (peopleCount <= 24)
            {
                transportExpenses = budget * 0.50;
            }
            else if (peopleCount <= 49)
            {
                transportExpenses = budget * 0.40;
            }
            else if (peopleCount > 50)
            {
                transportExpenses = budget * 0.25;
            }
            double totalCost = 0;
            if (ticketType == "VIP")
            {
                totalCost = 499.99 * peopleCount + transportExpenses;
            }
            else if (ticketType == "Normal")
            {
                totalCost = 249.99 * peopleCount + transportExpenses;
            }
            if (budget >= totalCost)
            {
                Console.WriteLine($"Yes! You have {budget - totalCost:f2} leva left.");
            }
            else if (totalCost > budget)
            {
                Console.WriteLine($"Not enough money! You need {totalCost - budget:f2} leva.");
            }
        }
    }
}
