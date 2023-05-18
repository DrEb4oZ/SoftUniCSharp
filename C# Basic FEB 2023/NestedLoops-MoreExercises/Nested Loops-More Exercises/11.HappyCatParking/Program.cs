using System;

namespace _11.HappyCatParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayCount = int.Parse(Console.ReadLine());
            int hourCountPerDay = int.Parse(Console.ReadLine());
            double totalTax = 0;


            for (int i = 1; i <= dayCount; i++)
            {
                double currentTax = 0;
                for (int j = 1; j <= hourCountPerDay; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        currentTax += 2.50;
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        currentTax += 1.25;
                    }
                    else
                    {
                        currentTax += 1;
                    }
                }
                Console.WriteLine($"Day: {i} - {currentTax:f2} leva");
                totalTax += currentTax;
            }
            Console.WriteLine($"Total: {totalTax:f2} leva");
        }
    }
}
