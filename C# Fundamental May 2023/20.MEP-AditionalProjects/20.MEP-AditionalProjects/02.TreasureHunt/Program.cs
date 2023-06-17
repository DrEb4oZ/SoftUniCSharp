using System.IO;

namespace _02.TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> treasureChest = Console.ReadLine()
                .Split("|")
                .ToList();
            string action;
            while ((action = Console.ReadLine()) != "Yohoho!")
            {
                string[] currentAction = action
                    .Split()
                    .ToArray();
                if (currentAction[0] == "Loot")
                {
                    for (int i = 1; i < currentAction.Length; i++)
                    {
                        if (!treasureChest.Contains(currentAction[i]))
                        {
                            treasureChest.Insert(0, currentAction[i]);
                        }
                    }
                }

                else if (currentAction[0] == "Drop")
                {
                    int index = int.Parse(currentAction[1]);
                    if (index >= 0 && index < treasureChest.Count)
                    {
                        treasureChest.Add(treasureChest[index]);
                        treasureChest.RemoveAt(index);
                    }
                }

                else if (currentAction[0] == "Steal")
                {
                    int count = int.Parse(currentAction[1]);
                    List<string> stolenItems = new List<string>();
                    if (count > treasureChest.Count)
                    {
                        for (int i = 0; i < treasureChest.Count; i++)
                        {
                            stolenItems.Add(treasureChest[i]);
                        }

                        treasureChest.RemoveRange(0, treasureChest.Count);
                        Console.WriteLine(string.Join(", ", stolenItems));
                    }

                    else
                    {
                        for (int i = treasureChest.Count - count; i < treasureChest.Count; i++)
                        {
                            stolenItems.Add(treasureChest[i]);
                        }

                        treasureChest.RemoveRange(treasureChest.Count - count, count);
                        Console.WriteLine(string.Join(", ", stolenItems));
                    }
                }
            }

            int sumLengthOfItemsInChest = 0;
            foreach (string item in treasureChest)
            {
                sumLengthOfItemsInChest += item.Length;
            }

            if (treasureChest.Count > 0)
            {
                double averageGain = (double)sumLengthOfItemsInChest / treasureChest.Count;
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}