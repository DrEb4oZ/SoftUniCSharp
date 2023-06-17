using System;
using System.Transactions;

namespace _03.ManOWar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShipStatus = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToList();
            List<int> warshipStatus = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToList();
            int maxHealthCapacity = int.Parse(Console.ReadLine());
            string action;
            while ((action = Console.ReadLine()) != "Retire")
            {
                string[] currentAction = action
                    .Split();
                if (currentAction[0] == "Fire")
                {
                    int index = int.Parse(currentAction[1]);
                    int damage = int.Parse(currentAction[2]);
                    if (index >= 0 && index < warshipStatus.Count)
                    {
                        warshipStatus[index] -= damage;
                        if (warshipStatus[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }

                else if (currentAction[0] == "Defend")
                {
                    int startIndex = int.Parse(currentAction[1]);
                    int endIndex = int.Parse(currentAction[2]);
                    int damage = int.Parse(currentAction[3]);
                    if (startIndex >= 0 && startIndex < pirateShipStatus.Count && endIndex >= 0 && endIndex < pirateShipStatus.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShipStatus[i] -= damage;
                            if (pirateShipStatus[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }

                else if (currentAction[0] == "Repair")
                {
                    int index = int.Parse(currentAction[1]);
                    int health = int.Parse(currentAction[2]);
                    if (index >= 0 && index < pirateShipStatus.Count)
                    {
                        pirateShipStatus[index] += health;
                        if (pirateShipStatus[index] > maxHealthCapacity)
                        {
                            pirateShipStatus[index] = maxHealthCapacity;
                        }
                    }
                }

                else if (currentAction[0] == "Status")
                {
                    int sectionsNeedRepair = 0;
                    for (int i = 0; i < pirateShipStatus.Count; i++)
                    {
                        double currentSectionPercentOfCapacity = (double)pirateShipStatus[i] / maxHealthCapacity;
                        if (currentSectionPercentOfCapacity < 0.20)
                        {
                            sectionsNeedRepair++;
                        }
                    }

                    Console.WriteLine($"{sectionsNeedRepair} sections need repair.");
                }
            }
            int sumPirateShipSections = 0;
            int sumWarshipSections = 0;

            foreach (int section in pirateShipStatus)
            {
                sumPirateShipSections += section;
            }

            foreach (int section in warshipStatus)
            {
                sumWarshipSections += section;
            }

            Console.WriteLine($"Pirate ship status: {sumPirateShipSections}\nWarship status: {sumWarshipSections} ");
        }
    }
}