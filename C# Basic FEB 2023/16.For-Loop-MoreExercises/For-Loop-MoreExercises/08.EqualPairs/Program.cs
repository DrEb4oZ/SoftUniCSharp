using System;
using System.Runtime.ExceptionServices;

namespace _08.EqualPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isEqual = true;
            int sum = 0;
            int diff = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int currentSum = firstNumber + secondNumber;
                
                if (currentSum != sum && i > 0)
                {
                    isEqual = false;
                    int currentDiff = Math.Abs(currentSum - sum);
                    if (currentDiff > diff)
                    {
                        diff = currentDiff;
                    }
                }
                else
                {
                    isEqual = true;
                }
                sum = currentSum;
            }
            if (isEqual)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={diff}");
            }
        }
    }
}
