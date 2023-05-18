using System;

namespace _03.Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cargoCount = int.Parse(Console.ReadLine());
            int totalPrice = 0;
            int totalWeight = 0;
            int cargoWeightMicrobus = 0, cargoWeightTruck = 0, cargoWeightTrain = 0;
            for (int i = 0; i < cargoCount; i++)
            {
                int cargoWeightT = int.Parse(Console.ReadLine());
                totalWeight += cargoWeightT;
                if (cargoWeightT <= 3)
                {
                    totalPrice += cargoWeightT * 200;
                    cargoWeightMicrobus += cargoWeightT;
                }
                else if (cargoWeightT <= 11)
                {
                    totalPrice += cargoWeightT * 175;
                    cargoWeightTruck += cargoWeightT;
                }
                else if (cargoWeightT >= 12)
                {
                    totalPrice += cargoWeightT * 120;
                    cargoWeightTrain += cargoWeightT;
                }
            }
            double avaragePrice = (double)totalPrice / totalWeight;
            double microbusWeightPercentage = (double)cargoWeightMicrobus / totalWeight * 100;
            double truckWeightPercentage = (double)cargoWeightTruck / totalWeight * 100;
            double trainWeightPercentage = (double)cargoWeightTrain / totalWeight * 100;

            Console.WriteLine($"{avaragePrice:f2}");
            Console.WriteLine($"{microbusWeightPercentage:f2}%");
            Console.WriteLine($"{truckWeightPercentage:f2}%");
            Console.WriteLine($"{trainWeightPercentage:f2}%");
        }
    }
}
