using System;

namespace _09.House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int controlNumber = n;
            int roofRow = 1;
            for (int i = 0; i < Math.Ceiling((double)n / 2); i++)
            {
                if (n % 2 == 0)
                {
                    for (int j = (controlNumber - roofRow) / 2; j > 0; j--)
                    {
                        Console.Write("-");
                    }
                }
                else
                {
                    for (int j = (controlNumber - roofRow) / 2; j > 0; j--)
                    {
                        Console.Write("-");
                    }
                }
                for (int j = 0; j < roofRow - 1; j++)
                {
                    Console.Write("**");
                }
                if (n % 2 == 0)
                {
                    Console.Write("**");
                }
                else
                {
                    Console.Write("*");
                }
                if (n % 2 == 0)
                {
                    for (int j = (controlNumber - roofRow) / 2; j > 0; j--)
                    {
                        Console.Write("-");
                    }
                }
                else
                {
                    for (int j = (controlNumber - roofRow) / 2; j > 0; j--)
                    {
                        Console.Write("-");
                    }
                }
                controlNumber--;
                roofRow++;
                Console.WriteLine();
            }
            controlNumber = n;
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write("|");
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write("*");
                }
                Console.Write("|");
                Console.WriteLine();
                controlNumber++;
            }
        }
    }
}
