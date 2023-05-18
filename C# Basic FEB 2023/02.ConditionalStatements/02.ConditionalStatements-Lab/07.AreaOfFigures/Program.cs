using System;

namespace _07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double AreaSquare = a * a;
                Console.WriteLine($"{AreaSquare:f3}");
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double AreaRectangle = a * b;
                Console.WriteLine($"{AreaRectangle:f3}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double AreaCircle = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"{AreaCircle:f3}");
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double AreaTriangle = a * h / 2;
                Console.WriteLine($"{AreaTriangle:f3}");
            }
        }
    }
}
