using System;
using System.Globalization;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());


            double liters = lenght * width * height * (1 - percent / 100.00) * 0.001;

            Console.WriteLine(liters);
        }
    }
}
