using System;

namespace _03.Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vineyardSqrMeteres = int.Parse(Console.ReadLine());
            double grapeOnSqrMeter = double.Parse(Console.ReadLine());
            int requierdLitersOfWine = int.Parse(Console.ReadLine());
            int workerCount = int.Parse(Console.ReadLine());
            double totalGrapeInKg = vineyardSqrMeteres * grapeOnSqrMeter * 0.40;
            double wineInLiters = totalGrapeInKg / 2.50;
            if (wineInLiters >= requierdLitersOfWine)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineInLiters)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineInLiters - requierdLitersOfWine)} liters left -> {Math.Ceiling((wineInLiters - requierdLitersOfWine)/workerCount)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(requierdLitersOfWine - wineInLiters)} liters wine needed.");
            }

        }
    }
}
