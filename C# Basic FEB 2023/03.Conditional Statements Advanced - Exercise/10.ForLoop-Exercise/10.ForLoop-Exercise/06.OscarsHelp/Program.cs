using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameActor = Console.ReadLine();
            double startPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double finalEstimatorPoints = startPoints;
            for (int i = 1; i <= n && finalEstimatorPoints <= 1250.50; i++)
            {
                string nameEstimator = Console.ReadLine();
                double pointsEstimator = double.Parse(Console.ReadLine());
                int lengthNameEstimator = nameEstimator.Length;

                finalEstimatorPoints = finalEstimatorPoints + ((double)lengthNameEstimator * pointsEstimator) / 2;
            }

            if (finalEstimatorPoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {finalEstimatorPoints:f1}!");
            }
            else if (finalEstimatorPoints <= 1250.5)
            {
                double pointsNeeded = 1250.50 - finalEstimatorPoints;
                Console.WriteLine($"Sorry, {nameActor} you need {pointsNeeded:f1} more!");
            }
        }
    }
}
