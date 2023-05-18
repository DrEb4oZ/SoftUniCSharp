using System;

namespace _07.FuelTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelInCar = double.Parse(Console.ReadLine());
            if (fuelInCar >= 25)
            {
                if(fuelType == "Diesel")
                    Console.WriteLine($"You have enough {fuelType.ToLower()}.");
                else if (fuelType == "Gasoline")
                    Console.WriteLine($"You have enough {fuelType.ToLower()}.");
                else if (fuelType == "Gas")
                    Console.WriteLine($"You have enough {fuelType.ToLower()}.");
                else
                    Console.WriteLine("Invalid fuel!");
            }
            else
            {
                if (fuelType == "Diesel")
                    Console.WriteLine($"Fill your tank with {fuelType.ToLower()}!");
                else if (fuelType == "Gasoline")
                    Console.WriteLine($"Fill your tank with {fuelType.ToLower()}!");
                else if (fuelType == "Gas")
                    Console.WriteLine($"Fill your tank with {fuelType.ToLower()}!");
                else
                    Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
