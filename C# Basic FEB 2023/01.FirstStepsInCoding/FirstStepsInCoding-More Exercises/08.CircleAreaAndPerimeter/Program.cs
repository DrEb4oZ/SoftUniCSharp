using System;
using System.Reflection.Metadata;

namespace _08.CircleAreaAndPerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius,2);
            double perimeter = 2 * Math.PI * radius;

            Console.WriteLine(Math.Round(area, 2));
            Console.WriteLine(Math.Round(perimeter, 2));

        }
    }
}
