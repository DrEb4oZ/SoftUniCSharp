using System;

namespace _05.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string vacationLocation = string.Empty;
            string vacationType = string.Empty;
            double vacationPrice = 0;
            if (budget <= 1000)
            {
                vacationType = "Camp";
                if (season == "Summer")
                {
                    vacationLocation = "Alaska";
                    vacationPrice = 0.65 * budget;
                }
                else if (season == "Winter")
                {
                    vacationLocation = "Morocco";
                    vacationPrice = 0.45 * budget;
                }
            }
            else if (budget <= 3000)
            {
                vacationType = "Hut";
                if (season == "Summer")
                {
                    vacationLocation = "Alaska";
                    vacationPrice = 0.80 * budget;
                }
                else if (season == "Winter")
                {
                    vacationLocation = "Morocco";
                    vacationPrice = 0.60 * budget;
                }
            }
            else if (budget > 3000)
            {
                vacationType = "Hotel";
                vacationPrice = 0.90 * budget;
                if (season == "Summer")
                {
                    vacationLocation = "Alaska";
                }
                else if (season == "Winter")
                {
                    vacationLocation = "Morocco";
                }
            }
            Console.WriteLine($"{vacationLocation} - {vacationType} - {vacationPrice:f2}");
        }
    }
}
