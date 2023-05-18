using System;

namespace _11.OddOrEvenPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0, evenSum = 0, oddMin = int.MaxValue, oddMax = int.MinValue, evenMin = int.MaxValue, evenMax = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += currentNumber;
                    if (currentNumber > evenMax)
                    {
                        evenMax = currentNumber;
                    }
                    if (currentNumber < evenMin)
                    {
                        evenMin = currentNumber;
                    }
                }
                else
                {
                    oddSum += currentNumber;
                    if (currentNumber > oddMax)
                    {
                        oddMax = currentNumber;
                    }
                    if (currentNumber < oddMin)
                    {
                        oddMin = currentNumber;
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddMin == int.MaxValue)
            {
                Console.WriteLine("OddMin=No,");
            }
            else Console.WriteLine($"OddMin={oddMin:f2},");
            if (oddMax == int.MinValue)
            {
                Console.WriteLine("OddMax=No,");
            }
            else Console.WriteLine($"OddMax={oddMax:f2},");
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenMin == int.MaxValue)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else Console.WriteLine($"EvenMin={evenMin:f2},");
            if (evenMax == int.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else Console.WriteLine($"EvenMax={evenMax:f2}");
        }
    }
}
