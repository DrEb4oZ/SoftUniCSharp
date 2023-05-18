using System;

namespace _07.ChristmasTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = 1;
            int controlNumber = n;

            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < controlNumber; j++)
                {
                    Console.Write(" ");
                }
                if (row > 1)
                {
                    for (int l = 0; l < row - 1; l++)
                    {
                        Console.Write("*");
                    }
                }
                Console.Write(" ");
                Console.Write("|");
                Console.Write(" ");
                if (row > 1)
                {
                    for (int m = 0; m < row - 1; m++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
                controlNumber--;
                row++;
            }
        }
    }
}
