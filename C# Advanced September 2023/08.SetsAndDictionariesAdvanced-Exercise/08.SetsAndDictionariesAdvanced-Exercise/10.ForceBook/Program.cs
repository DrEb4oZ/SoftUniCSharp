using System.ComponentModel.Design;
/*
P -> Dark
P -> Light
P -> Dark
Light | P
Lumpawaroo

 */
namespace _10.ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, HashSet<string>> forcesUsers = new SortedDictionary<string, HashSet<string>>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] commandTokens = command
                    .Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string splitter = commandTokens[1];
                if (command.Contains("|"))
                {
                    string sideToAdd = commandTokens[0];
                    string userToAdd = commandTokens[1];
                    if (!forcesUsers.Values.Any(x => x.Contains(userToAdd)))
                    {
                        if (!forcesUsers.ContainsKey(sideToAdd))
                        {
                            forcesUsers.Add(sideToAdd, new HashSet<string>());
                        }
                        forcesUsers[sideToAdd].Add(userToAdd);
                    }
                }

                else
                {
                    string userToChange = commandTokens[0];
                    string sideToChangeTo = commandTokens[1];
                    foreach (KeyValuePair<string, HashSet<string>> users in forcesUsers)
                    {
                        if (users.Value.Contains(userToChange))
                        {
                            users.Value.Remove(userToChange);
                            break;
                        }
                    }

                    if (!forcesUsers.ContainsKey(sideToChangeTo))
                    {
                        forcesUsers.Add(sideToChangeTo, new HashSet<string>());
                    }
                    forcesUsers[sideToChangeTo].Add(userToChange);
                    Console.WriteLine($"{userToChange} joins the {sideToChangeTo} side!");
                }
            }

            foreach (KeyValuePair<string, HashSet<string>> users in forcesUsers.OrderByDescending(x => x.Value.Count))
            {
                if (users.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {users.Key}, Members: {users.Value.Count}");
                    foreach (string user in users.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}