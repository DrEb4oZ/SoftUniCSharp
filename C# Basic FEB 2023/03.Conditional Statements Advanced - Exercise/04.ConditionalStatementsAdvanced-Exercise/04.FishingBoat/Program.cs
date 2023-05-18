using System;

namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());
            double boatRent = 0;
            if (season == "Spring")
            {
                if (fishermanCount <= 6)
                {
                    boatRent = 3000 * 0.90;
                }
                else if (fishermanCount >7 && fishermanCount <= 11)
                {
                    boatRent = 3000 * 0.85;
                }
                else if (fishermanCount > 11)
                {
                    boatRent = 3000 * 0.75;
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                if (fishermanCount <= 6)
                {
                    boatRent = 4200 * 0.90;
                }
                else if (fishermanCount > 7 && fishermanCount <= 11)
                {
                    boatRent = 4200 * 0.85;
                }
                else if (fishermanCount > 11)
                {
                    boatRent = 4200 * 0.75;
                }
            }
            else if (season == "Winter")
            {
                if (fishermanCount <= 6)
                {
                    boatRent = 2600 * 0.90;
                }
                else if (fishermanCount > 7 && fishermanCount <= 11)
                {
                    boatRent = 2600 * 0.85;
                }
                else if (fishermanCount > 11)
                {
                    boatRent = 2600 * 0.75;
                }
            }
            if (fishermanCount % 2 == 0 && season != "Autumn")
            {
                boatRent = boatRent * 0.95;
            }
            if (budget >= boatRent)
            {
                Console.WriteLine($"Yes! You have {budget - boatRent:f2} leva left.");
            }    
            else if (boatRent > budget)
            {
                Console.WriteLine($"Not enough money! You need {boatRent - budget:f2} leva.");
            }
        }
    }
}
