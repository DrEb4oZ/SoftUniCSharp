using System;

namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int penCount = int.Parse(Console.ReadLine());
            int markerCount = int.Parse(Console.ReadLine());
            int cleaningAgent = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double sum = (penCount * 5.80 + markerCount * 7.20 + cleaningAgent * 1.2) * (1 - discount / 100.00);

            Console.WriteLine(sum);
        }
    }
}
