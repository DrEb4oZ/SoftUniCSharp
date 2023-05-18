using System;
using System.Net;

namespace _02.BikeRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniorBikers = int.Parse(Console.ReadLine());
            int seniorBikers = int.Parse(Console.ReadLine());
            string traceType = Console.ReadLine();

            double participationTax = 0;
            if (traceType == "trail")
            {
                participationTax = juniorBikers * 5.50 + seniorBikers * 7.00;
            }
            else if (traceType == "cross-country")
            {
                participationTax = juniorBikers * 8 + seniorBikers * 9.50;

                if (seniorBikers + juniorBikers >= 50)
                {
                    participationTax = participationTax * 0.75;
                }
            }
            else if (traceType == "downhill")
            {
                participationTax = juniorBikers * 12.25 + seniorBikers * 13.75;
            }
            else if (traceType == "road")
            {
                participationTax = juniorBikers * 20 + seniorBikers * 21.50;
            }
            double totalIncome = participationTax * 0.95;
            Console.WriteLine($"{totalIncome:f2}");
        }
    }
}
