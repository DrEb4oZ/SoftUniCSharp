using System.Threading;
using System.Threading.Channels;

namespace _02.MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            string[] dungeonRooms = Console.ReadLine()
                .Split("|")
                .ToArray();
            for (int i = 0; i < dungeonRooms.Length; i++)
            {
                string[] currentDungeonRoom = dungeonRooms[i]
                    .Split()
                    .ToArray();
                string encounter = currentDungeonRoom[0];
                int amount = int.Parse(currentDungeonRoom[1]);
                if (encounter == "potion")
                {
                    if (health + amount > 100)
                    {
                        Console.WriteLine($"You healed for {100 - health} hp.");
                        health = 100;
                    }

                    else
                    {
                    health += amount;
                    Console.WriteLine($"You healed for {amount} hp.");
                    }

                    Console.WriteLine($"Current health: {health} hp.");
                }

                else if (encounter == "chest")
                {
                    bitcoins += amount;
                    Console.WriteLine($"You found {amount} bitcoins.");
                }

                else
                {
                    health -= amount;
                    if(health > 0)
                    {
                        Console.WriteLine($"You slayed {encounter}.");
                    }

                    else
                    {
                        Console.WriteLine($"You died! Killed by {encounter}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }
                }
            }

            if(health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}