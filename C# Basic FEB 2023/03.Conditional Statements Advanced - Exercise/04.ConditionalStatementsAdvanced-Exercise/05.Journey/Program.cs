using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            string vacationType = "";
            string destination = "";
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    price = 0.3 * budget;
                    vacationType = "Camp";
                }
                else if (season == "winter")
                {
                    price = 0.7 * budget;
                    vacationType = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    price = 0.4 * budget;
                    vacationType = "Camp";
                }
                else if (season == "winter")
                {
                    price = 0.80 * budget;
                    vacationType = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                price = 0.9 * budget;
                vacationType = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{vacationType} - {price:f2}");
        }
    }
}
