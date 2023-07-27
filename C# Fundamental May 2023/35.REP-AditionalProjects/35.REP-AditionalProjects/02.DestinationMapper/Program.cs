using System.Text.RegularExpressions;

namespace _02.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string markedLocations = Console.ReadLine();
            string filterMarkedLocations = @"([=|/])(?<validLocation>[A-Z][A-Za-z]{2,})\1";
            MatchCollection markedLocatonsCollection = Regex.Matches(markedLocations, filterMarkedLocations);
            int travelPoints = 0;
            List<string> locations = new List<string>();
            foreach (Match location in markedLocatonsCollection)
            {
                string currentLocation = location.Groups["validLocation"].Value;
                travelPoints += currentLocation.Length;
                locations.Add(currentLocation);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", locations)}\nTravel Points: {travelPoints}");
        }
    }
}