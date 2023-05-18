using System;

namespace _04.TransportPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int travelKm = int.Parse(Console.ReadLine());
            string partOfTheDay = Console.ReadLine();
            double taxyDayPrice = 0.70 + 0.79 * travelKm;
            double taxyNightPrice = 0.70 + 0.90 * travelKm;
            double busPrice = 0.09 * travelKm;
            double trainPrice = 0.06 * travelKm;
            if (travelKm >= 100)
            {
                Console.WriteLine($"{trainPrice:f2}");
            }
            else if (travelKm >= 20)
            {
                Console.WriteLine($"{busPrice:f2}");
            }
            else if (partOfTheDay == "day")
            {
                Console.WriteLine($"{taxyDayPrice:f2}");
            }
            else if (partOfTheDay == "night")
            {
                Console.WriteLine($"{taxyNightPrice:f2}");
            }
        }
    }
}
