using System;

namespace _08.FuelTank_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelAmount = double.Parse(Console.ReadLine());
            string cardOwnership = Console.ReadLine();
            if (fuelType == "Gas")
            {
                if (cardOwnership == "No")
                {
                    if (fuelAmount > 20 && fuelAmount <= 25)
                    {
                        Console.WriteLine($"{fuelAmount * 0.93 * 0.92:f2} lv.");
                    }
                    else if (fuelAmount > 25)
                    {
                        Console.WriteLine($"{fuelAmount * 0.93 * 0.9:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{fuelAmount * 0.93:f2} lv.");
                    }
                }
                else if (cardOwnership == "Yes")
                {
                    if (fuelAmount > 20 && fuelAmount <= 25)
                    {
                        Console.WriteLine($"{fuelAmount * (0.93 - 0.08) * 0.92:f2} lv.");
                    }
                    else if (fuelAmount > 25)
                    {
                        Console.WriteLine($"{fuelAmount * (0.93 - 0.08) * 0.9:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{fuelAmount * (0.93 - 0.08):f2} lv.");
                    }
                }
            }
            else if (fuelType == "Gasoline")
            {
                if (cardOwnership == "No")
                {
                    if (fuelAmount > 20 && fuelAmount <= 25)
                    {
                        Console.WriteLine($"{fuelAmount * 2.22 * 0.92:f2} lv.");
                    }
                    else if (fuelAmount > 25)
                    {
                        Console.WriteLine($"{fuelAmount * 2.22 * 0.9:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{fuelAmount * 2.22:f2} lv.");
                    }
                }
                else if (cardOwnership == "Yes")
                {
                    if (fuelAmount > 20 && fuelAmount <= 25)
                    {
                        Console.WriteLine($"{fuelAmount * (2.22 - 0.18) * 0.92:f2} lv.");
                    }
                    else if (fuelAmount > 25)
                    {
                        Console.WriteLine($"{fuelAmount * (2.22 - 0.18) * 0.9:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{fuelAmount * (2.22 - 0.18):f2} lv.");
                    }
                }
            }
            else if (fuelType == "Diesel")
            {
                if (cardOwnership == "No")
                {
                    if (fuelAmount > 20 && fuelAmount <= 25)
                    {
                        Console.WriteLine($"{fuelAmount * 2.33 * 0.92:f2} lv.");
                    }
                    else if (fuelAmount > 25)
                    {
                        Console.WriteLine($"{fuelAmount * 2.33 * 0.9:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{fuelAmount * 2.33:f2} lv.");
                    }
                }
                else if (cardOwnership == "Yes")
                {
                    if (fuelAmount > 20 && fuelAmount <= 25)
                    {
                        Console.WriteLine($"{fuelAmount * (2.33 - 0.12) * 0.92:f2} lv.");
                    }
                    else if (fuelAmount > 25)
                    {
                        Console.WriteLine($"{fuelAmount * (2.33 - 0.12) * 0.9:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{fuelAmount * (2.33 - 0.12):f2} lv.");
                    }
                }
            }
        }
    }
}
