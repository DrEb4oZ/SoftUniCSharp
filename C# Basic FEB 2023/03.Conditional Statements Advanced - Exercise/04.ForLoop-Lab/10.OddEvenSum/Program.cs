using System;

namespace _10.OddEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddPositionSum = 0;
            int evenPostionSum = 0;
            for (int i = 0; i < n; i+=1)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenPostionSum = evenPostionSum + number;
                }
                else
                {
                    oddPositionSum = oddPositionSum + number;
                }
            }
            if (oddPositionSum == evenPostionSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenPostionSum}");
            }
            else
            {
                int difference = oddPositionSum - evenPostionSum;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(difference)}");
            }
        }
    }
}
