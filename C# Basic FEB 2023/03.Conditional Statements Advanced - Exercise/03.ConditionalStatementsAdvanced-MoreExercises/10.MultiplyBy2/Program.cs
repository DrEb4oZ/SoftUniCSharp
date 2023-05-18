using System;

namespace _10.MultiplyBy2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            while (number >= 0)
            {
                double result = number * 2;
                Console.WriteLine($"Result: {result:f2}");
                number = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Negative number!");
        }
    }
}
