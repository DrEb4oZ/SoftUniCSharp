using System.Xml.Linq;

namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < commandsCount; i++)
            {
                string[] command = Console.ReadLine()
                    .Split()
                    .ToArray();
                if (command.Length == 3)
                {
                    if (guests.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }

                    else
                    {
                        guests.Add(command[0]);
                    }
                }

                else if (command.Length == 4)
                {
                    if (guests.Contains(command[0]))
                    {
                        guests.Remove(command[0]);
                    }

                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }

            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}