using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"(#|\|)(?<itemName>[A-Za-z\s]+)\1(?<expirationDate>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d{1,5})\1";
            MatchCollection validMatches = Regex.Matches(input, regex);
            int totalFoodCalories = 0;
            foreach (Match match in validMatches)
            {
                int calories = int.Parse(match.Groups["calories"].Value);
                totalFoodCalories += calories;
            }
            int days = totalFoodCalories / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match match in validMatches)
            {
                Console.WriteLine($"Item: {match.Groups["itemName"].Value}, Best before: {match.Groups["expirationDate"].Value}, Nutrition: {match.Groups["calories"].Value}");
            }
        }
    }
}