using System;

namespace _02.EqualSumsEvenOddPositionSecond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                int oddSum = 0, evenSum = 0;
                string currentNumber = i.ToString();
                for (int j = 0; j < currentNumber.Length; j++)
                {
                    int currentNumberPosition = int.Parse(currentNumber[j].ToString());
                    if (j % 2 == 0)
                    {
                        evenSum += currentNumberPosition;
                    }
                    else
                    {
                        oddSum += currentNumberPosition;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
