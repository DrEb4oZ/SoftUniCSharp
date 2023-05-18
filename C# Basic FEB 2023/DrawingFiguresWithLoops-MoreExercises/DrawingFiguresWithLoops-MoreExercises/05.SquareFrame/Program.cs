using System;

namespace _05.SquareFrame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = 1;
            int column = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (row == 1 || row == n)
                    {
                        if (column == 1 || column == n)
                        {
                            Console.Write("+ ");
                        }
                        else
                        {
                            Console.Write("- ");
                        }
                    }
                    else
                    {
                        if (column == 1 || column == n)
                        {
                            Console.Write("| ");
                        }
                        else
                        {
                            Console.Write("- ");
                        }
                    }
                    column++;
                }
                row++;
                column = 1;
                Console.WriteLine();
            }
        }
    }
}
