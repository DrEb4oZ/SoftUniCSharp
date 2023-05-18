using System;
using System.ComponentModel;

namespace _05.AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberCount = 0;
            int numberSum = 0;
            for (int i = 0; i < number; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numberCount++;
                numberSum += currentNumber;
            }
            double avarage = (double)numberSum / numberCount;
            Console.WriteLine($"{avarage:f2}");
        }
    }
}
