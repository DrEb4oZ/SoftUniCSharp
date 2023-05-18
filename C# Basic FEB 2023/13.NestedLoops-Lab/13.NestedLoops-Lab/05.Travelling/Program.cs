using System;

namespace _05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double savings = 0; 
                while (savings < budget)
                {
                    double currnetSaving = double.Parse(Console.ReadLine());
                    savings += currnetSaving;
                    if (savings >= budget)
                    {
                        Console.WriteLine($"Going to {destination}!");
                    }
                }

                destination = Console.ReadLine();
            }
        }
    }
}
