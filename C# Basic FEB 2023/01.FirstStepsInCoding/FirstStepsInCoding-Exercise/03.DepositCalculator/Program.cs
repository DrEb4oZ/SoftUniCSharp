using System;
using System.Reflection.Metadata;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int depositTerm = int.Parse(Console.ReadLine());
            double annualInterest = double.Parse(Console.ReadLine());

            double income = depositSum + depositTerm * ((depositSum * annualInterest / 100.00) / 12);

            Console.WriteLine(income);
        }
    }
}
