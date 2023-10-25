namespace _07.TheV_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> vloggers = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Statistics")
            {
                string[] commandTokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = commandTokens[1];
                switch (currentCommand)
                {
                    case "joined":
                        string newVlogger = commandTokens[0];
                        if (!vloggers.ContainsKey(newVlogger))
                        {
                            vloggers.Add(newVlogger, new Dictionary<string, HashSet<string>>());
                            vloggers[newVlogger].Add("followers", new HashSet<string>());
                            vloggers[newVlogger].Add("followed", new HashSet<string>());
                        }

                        break;

                    case "followed":
                        string follower = commandTokens[0];
                        string followed = commandTokens[2];
                        if (vloggers.ContainsKey(follower) && vloggers.ContainsKey(followed) && follower != followed && !vloggers[follower]["followed"].Contains(follower))
                        {
                            vloggers[followed]["followers"].Add(follower);
                            vloggers[follower]["followed"].Add(followed);
                        }

                        break;
                }

            }
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            Dictionary<string, Dictionary<string, HashSet<string>>> orderedVloggers = vloggers
                .OrderByDescending(x => x.Value["followers"].Count)
                .ThenBy(x => x.Value["followed"].Count)
                .ToDictionary(x => x.Key, x => x.Value);
            int printCounter = 1;
            foreach (var vlogger in orderedVloggers)
            {
                Console.WriteLine($"{printCounter}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["followed"].Count} following");
                if (printCounter == 1)
                {

                    foreach (var followers in vlogger.Value["followers"].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {followers}");
                    }
                }
                printCounter++;
            }
        }
    }
}