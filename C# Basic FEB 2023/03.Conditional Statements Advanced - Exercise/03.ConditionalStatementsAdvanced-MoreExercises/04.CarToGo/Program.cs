using System;

namespace _04.CarToGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string carType = string.Empty;
            string carClass = string.Empty;
            double carRent = 0;
            if (budget <= 100) 
            {
                carClass = "Economy class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    carRent = 0.35 * budget;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    carRent = 0.65 * budget;
                }
            }
            else if (budget <= 500)
            {
                carClass = "Compact class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    carRent = 0.45 * budget;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    carRent = 0.80 * budget;
                }
            }
            else if (budget > 500)
            {
                carClass = "Luxury class";
                carType = "Jeep";
                carRent = 0.90 * budget;
            }
            Console.WriteLine($"{carClass}");
            Console.WriteLine($"{carType} - {carRent:f2}");
        }
    }
}
