using System;
using System.ComponentModel;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int naylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluted = int.Parse(Console.ReadLine());
            int workHours = int.Parse(Console.ReadLine());

            double materialCost = (naylon * 1.5 + 2 * 1.5) + (paint * 14.50 + paint * 0.1 * 14.50) + (diluted * 5) + 0.40;
            double wage = materialCost * 0.3 * workHours;
            double totalCost = materialCost + wage;

            Console.WriteLine(totalCost);
        }
    }
}
