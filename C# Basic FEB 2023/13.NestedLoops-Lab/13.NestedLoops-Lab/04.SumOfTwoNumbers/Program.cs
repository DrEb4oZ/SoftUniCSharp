using System;

namespace _04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int stopNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0;
            bool isTrue = false;
            for (int i = startNumber; i <= stopNumber; i++)
            {
                for (int j = startNumber; j <= stopNumber; j++)
                {
                    count++;
                    if (i + j == magicNumber)
                    {
                        isTrue = true;
                        break;
                    }
                }
                if (isTrue)
                {
                    break;
                }
            }
            if (isTrue)
            {
                Console.WriteLine($"Combination N:{count} ({startNumber} + {stopNumber} = {magicNumber})");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }
        }
    }
}
