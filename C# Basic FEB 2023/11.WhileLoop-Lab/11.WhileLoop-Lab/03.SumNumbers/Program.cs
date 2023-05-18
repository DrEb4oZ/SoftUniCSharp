using System;

namespace _03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberSum = 0;
            while (true)
            {
                int input = int.Parse(Console.ReadLine());
                numberSum += input;
                if (numberSum >= number)
                {
                    Console.WriteLine(numberSum);
                    break;
                }
                
            }
        }
    }
}
