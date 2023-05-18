using System;

namespace _03.Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int SideB = int.Parse(Console.ReadLine());
            int area = sideA * SideB;
            Console.WriteLine(area);
        }
    }
}
