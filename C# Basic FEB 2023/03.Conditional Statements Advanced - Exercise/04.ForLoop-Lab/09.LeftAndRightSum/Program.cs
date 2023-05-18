using System;

namespace _09.LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int leftNumberSum = 0;
            int rightNumberSum = 0;
            for (int i = 0; i < number; i+=1)
            {
                int leftNumber = int.Parse(Console.ReadLine());
                leftNumberSum = leftNumberSum + leftNumber;
            }
            for (int i = 0; i < number; i += 1)
            {
                int rightNumber = int.Parse(Console.ReadLine());
                rightNumberSum = rightNumberSum + rightNumber;
            }
            if (leftNumberSum == rightNumberSum)
            {
                Console.WriteLine($"Yes, sum = {leftNumberSum}");
            }
            else
            {
                int difference = leftNumberSum - rightNumberSum;
                Console.WriteLine($"No, diff = {Math.Abs(difference)}");
            }
        }
    }
}
