using System;

namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double curentRecord = double.Parse(Console.ReadLine());
            double swimDistanceInMeters = double.Parse(Console.ReadLine());
            double swimTimePerMeterInSecond = double.Parse(Console.ReadLine());
            double totalTime = swimDistanceInMeters * swimTimePerMeterInSecond;
            double resistanceCount = swimDistanceInMeters / 15;
            double resistance = Math.Floor(resistanceCount) * 12.50;
            totalTime = totalTime + resistance;
            if (totalTime < curentRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - curentRecord:f2} seconds slower.");
            }

        }
    }
}
