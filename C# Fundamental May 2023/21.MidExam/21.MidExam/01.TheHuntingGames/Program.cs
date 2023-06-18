using System.Diagnostics.Metrics;

namespace _01.TheHuntingGames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysAdventuring = int.Parse(Console.ReadLine());
            int playersCount = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDayPerPerson = double.Parse(Console.ReadLine());
            double foodPerDayPerPerson = double.Parse(Console.ReadLine());
            int secondDayCount = 0;
            int thirdDayCount = 0;
            double totalWater = daysAdventuring * playersCount * waterPerDayPerPerson;
            double totalFood = daysAdventuring * playersCount * foodPerDayPerPerson;
            bool isMissionSuccesfull = true;
            for (int i = 0; i < daysAdventuring; i++)
            {
                secondDayCount++;
                thirdDayCount++;
                double energyLoss = double.Parse(Console.ReadLine());
                groupEnergy -= energyLoss;
                if (groupEnergy <= 0)
                {
                    isMissionSuccesfull = false;
                    break;
                }

                if (secondDayCount == 2)
                {
                    groupEnergy *= 1.05;
                    totalWater *= 0.70;
                    secondDayCount = 0;
                }

                if (thirdDayCount == 3)
                {
                    double foodConsumed = totalFood / playersCount;
                    totalFood -= foodConsumed;
                    groupEnergy *= 1.10;
                    thirdDayCount = 0;
                }
            }

            if (isMissionSuccesfull)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
            }

            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
            }
        }
    }
}