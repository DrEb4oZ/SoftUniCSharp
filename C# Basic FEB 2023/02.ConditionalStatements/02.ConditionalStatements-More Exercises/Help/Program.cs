using System;

namespace Help
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());

            double space = X * 0.4;
            double grape = Y * space;
            double literWine = grape / 2.5;

            if (literWine < Z)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(Z - literWine)} liters wine needed.");
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(Z - literWine)} liters wine needed.");
            }

            else if (literWine >= Z)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(literWine)} liters.");
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(literWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(literWine - Z)} liters left -> {Math.Ceiling(literWine - Z) / people} liters per person.");
                Console.WriteLine($"{Math.Ceiling(literWine - Z)} liters left -> {Math.Ceiling((literWine - Z) / people)} liters per person.");
            }
        }
    }
}
