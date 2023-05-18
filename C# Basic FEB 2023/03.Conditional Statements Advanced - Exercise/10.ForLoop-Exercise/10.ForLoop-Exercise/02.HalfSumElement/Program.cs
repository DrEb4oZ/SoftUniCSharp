using Microsoft.VisualBasic;
using System;
using System.Diagnostics.Contracts;

namespace _02.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = int.MinValue;
            int numberSum = 0;
            for (int i = 0; i < n; i++)
            {
                int controlNumber = int.Parse(Console.ReadLine());
                
                if (number < controlNumber)
                {
                    number = controlNumber;
                }
                numberSum += controlNumber;
            }
            if (numberSum - number == number)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {number}");
            }
            else
            {
                int difference = Math.Abs(number - (numberSum - number));
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {difference}");
            }
        }
    }
}
