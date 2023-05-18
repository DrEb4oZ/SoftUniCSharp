using System;

namespace _05.TrainingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double countW = (width * 100.0 -100) / 70;
            double countL = lenght * 100.0 / 120;

            double seats = Math.Truncate(countW) * Math.Truncate(countL) - 3;

            Console.WriteLine(seats);
        }
    }
}
