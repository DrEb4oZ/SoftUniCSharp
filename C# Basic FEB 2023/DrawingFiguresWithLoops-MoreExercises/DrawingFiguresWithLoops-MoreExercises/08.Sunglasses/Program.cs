using System;

namespace _08.Sunglasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double row = 2;
            double controlNumber = n;
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            
            for (int l = 0; l < n - 2; l++)
            {
                Console.Write("*");
                for (int i = 0; i < n * 2 - 2; i++)
                {
                    Console.Write("/");
                }
                Console.Write("*");
                if (Math.Ceiling((double)n / 2) == row)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("|");
                    }
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("*");
                for (int i = 0; i < n * 2 - 2; i++)
                {
                    Console.Write("/");
                }
                Console.Write("*");
                Console.WriteLine();
                row++;
            }
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("*");
            }
        }
    }
}
