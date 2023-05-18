using System;

namespace _06.RhombusOfStarsSecond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n - row; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int k = 0; k < row - 1; k++)
                {
                    Console.Write(" *");
                }
                row++;
                Console.WriteLine();
            }
            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 0; j < n - row; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int k = 0; k < row - 1; k++)
                {
                    Console.Write(" *");
                }
                row++;
                Console.WriteLine();
            }
        }
    }
}
