using System;

namespace _07.HousePainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double greenArea = (2 * x * x - 1.2 * 2) + (2 * x * y - 2 * 1.5 * 1.5);
            double redArea = (2 * x * y) + (2 * x * h / 2);

            Console.WriteLine($"{greenArea / 3.4:f2}");
            Console.WriteLine($"{redArea / 4.3:f2}");
        }
    }
}
