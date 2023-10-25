using System.Linq;
using System.Net.Http.Headers;

namespace _09.PredicateParty_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string doubleOrReomove = tokens[0];
                string currentCommand = tokens[1];
                string criteria = tokens[2];
                
                if(doubleOrReomove == "Remove")
                {
                    guests.RemoveAll(GetPredicate(currentCommand, criteria));
                }

                else
                {
                    List<string> peopleToDouble = guests.FindAll(GetPredicate(currentCommand, criteria));

                    foreach (string person in peopleToDouble)
                    {
                        int index = guests.FindIndex(p => p == person);
                        guests.Insert(index, person);
                    }
                }
            }
            if (guests.Any())
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        static Predicate<string> GetPredicate(string currentCommand, string criteria)
        {
            switch (currentCommand)
            {
                case "StartsWith":
                    return p => p.StartsWith(criteria);
                case "EndsWith":
                    return p => p.EndsWith(criteria);
                case "Length":
                return p => p.Length == int.Parse(criteria);
                default:
                    return default;
            }
        }
    }
}