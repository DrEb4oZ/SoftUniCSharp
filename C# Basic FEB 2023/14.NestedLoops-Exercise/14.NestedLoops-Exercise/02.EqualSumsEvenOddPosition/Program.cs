using System;

namespace _02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int currentNumber = 0;
            

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                int evenSum = 0;
                int oddSum = 0;
                int digitPosition = 1;
                currentNumber = i;

                while (currentNumber != 0)
                {
                    int lastDigit = currentNumber % 10;
                    if (digitPosition % 2 == 0)
                    {
                        evenSum += lastDigit;
                    }
                    else
                    {
                        oddSum += lastDigit;
                    }
                    currentNumber /= 10;
                    digitPosition++;
                    
                }
                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
