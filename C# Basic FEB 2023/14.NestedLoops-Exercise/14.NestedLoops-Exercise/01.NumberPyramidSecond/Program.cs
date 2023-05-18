using System;

namespace _01.NumberPyramidSecond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int row = 1;
            int currentNumber = 1;
            bool stopProgram = false;

            while (currentNumber <= number)
            {
                for (int i = 0; i < row; i++)
                {
                    Console.Write(currentNumber + " ");
                    
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
