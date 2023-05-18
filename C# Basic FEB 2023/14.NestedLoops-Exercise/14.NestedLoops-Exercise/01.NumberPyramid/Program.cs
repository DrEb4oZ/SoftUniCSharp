using System;
using System.Globalization;

namespace _01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int row = 1;
            bool stopProgram = false;
            int currentNumber = 1;
            while (currentNumber <= number)
            {
                for (int j = 1; j <= row; j++)
                {
                    Console.Write($"{currentNumber} ");
                    
                    if (currentNumber == number)
                    {
                        stopProgram = true;
                        break;
                    }
                    currentNumber++;
                }
                row++;
                if (stopProgram)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
