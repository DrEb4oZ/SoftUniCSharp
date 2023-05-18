using System;
using System.ComponentModel;

namespace _06.TruckDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double monthKm = double.Parse(Console.ReadLine());
            double income = 0;
            if (monthKm <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    income = 0.75 * monthKm * 4;
                }
                else if (season == "Summer")
                {
                    income = 0.90 * monthKm * 4;
                }
                else if (season == "Winter")
                {
                    income = 1.05 * monthKm * 4;
                }
            }
            else if (monthKm <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    income = 0.95 * monthKm * 4;
                }
                else if (season == "Summer")
                {
                    income = 1.10 * monthKm * 4;
                }
                else if (season == "Winter")
                {
                    income = 1.25 * monthKm * 4;
                }
            }
            else if (monthKm <= 20000)
            {
                income = 1.45 * monthKm * 4;
            }
            double totalIncome = income * 0.90;
            Console.WriteLine($"{totalIncome:f2}");
        }
    }
}
