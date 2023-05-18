using System;

namespace _04.TriangleOfDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write("$ ");
                }
                row++;
                Console.WriteLine();
            }
        }
    }
}
