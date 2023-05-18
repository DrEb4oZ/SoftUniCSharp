using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string evaluaterName = string.Empty;
            double evaluaterPoints = 0;
            double totalPoints = academyPoints;
            for (int i = 0; i < n && totalPoints <= 1250.50; i++)
            {
                evaluaterName = Console.ReadLine();
                evaluaterPoints = double.Parse(Console.ReadLine());
                totalPoints += evaluaterName.Length * evaluaterPoints / 2;
            }
            if (totalPoints > 1250.50)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:f1}!");
            }
            else
            {
                double pointsNeeded = 1250.50 - totalPoints;
                Console.WriteLine($"Sorry, {actorName} you need {pointsNeeded:f1} more!");
            }
        }
    }
}
