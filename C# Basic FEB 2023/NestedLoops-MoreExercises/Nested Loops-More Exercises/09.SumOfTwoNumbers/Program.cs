using System;

namespace _09.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int countCombination = 0;
            bool isValid = false;

            for (int i = startNumber; i <= lastNumber; i++)
            {
                for (int j = startNumber; j <= lastNumber && !isValid; j++)
                {
                    countCombination++;
                    int currentSum = i + j;
                    if (currentSum == magicNumber)
                    {
                        isValid = true;
                        Console.WriteLine($"Combination N:{countCombination} ({i} + {j} = {magicNumber})");
                    }
                }
            }
            if (!isValid)
            {
                Console.WriteLine($"{countCombination} combinations - neither equals {magicNumber}");
            }
        }
    }
}
