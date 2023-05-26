using System;
using System.Diagnostics.Tracing;

namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] secondArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            bool notEqual = false;
            int differentIndex = 0;
            for (int i = 0; i < firstArray.Length && !notEqual; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    sum += firstArray[i];
                }

                else
                {
                    notEqual = true;
                    differentIndex = i;
                }

            }

            if (notEqual)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {differentIndex} index");
            }

            else
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

        }
    }
}