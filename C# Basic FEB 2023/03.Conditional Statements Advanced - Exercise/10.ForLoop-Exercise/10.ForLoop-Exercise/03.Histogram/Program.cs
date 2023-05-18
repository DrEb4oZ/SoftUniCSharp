using System;

namespace _03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    p1 += 1;
                }
                else if (number <= 399)
                {
                    p2 += 1;
                }
                else if (number <= 599)
                {
                    p3 += 1;
                }
                else if (number <= 799)
                {
                    p4 += 1;
                }
                else if (number >= 800)
                {
                    p5 += 1;
                }
            }
            Console.WriteLine($"{(double) p1 / n * 100:f2}%");
            Console.WriteLine($"{(double) p2 / n * 100:f2}%");
            Console.WriteLine($"{(double) p3 / n * 100:f2}%");
            Console.WriteLine($"{(double) p4 / n * 100:f2}%");
            Console.WriteLine($"{(double) p5 / n * 100:f2}%");
        }
    }
}
