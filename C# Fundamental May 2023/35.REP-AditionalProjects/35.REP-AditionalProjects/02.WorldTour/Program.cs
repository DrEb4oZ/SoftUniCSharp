namespace _02.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string travelingLocations = Console.ReadLine();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] commandTokens = command.Split(":");
                string currentCommand = commandTokens[0];
                switch (currentCommand)
                {
                    case "Add Stop":
                        int insertIndex = int.Parse(commandTokens[1]);
                        string valueToInsert = commandTokens[2];
                        if (insertIndex >= 0 && insertIndex < travelingLocations.Length)
                        {
                            travelingLocations = travelingLocations.Insert(insertIndex, valueToInsert);
                        }
                        Console.WriteLine(travelingLocations);

                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(commandTokens[1]);
                        int endIndex = int.Parse(commandTokens[2]);
                        if (startIndex >= 0 && startIndex < travelingLocations.Length && endIndex >= startIndex && endIndex < travelingLocations.Length)
                        {
                            travelingLocations = travelingLocations.Remove(startIndex, endIndex - startIndex + 1);
                        }
                        Console.WriteLine(travelingLocations);

                        break;
                    case "Switch":
                        string oldStringValue = commandTokens[1];
                        string newStringValue = commandTokens[2];
                        travelingLocations = travelingLocations.Replace(oldStringValue, newStringValue);
                        Console.WriteLine(travelingLocations);
                        break;
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {travelingLocations}");
        }
    }
}