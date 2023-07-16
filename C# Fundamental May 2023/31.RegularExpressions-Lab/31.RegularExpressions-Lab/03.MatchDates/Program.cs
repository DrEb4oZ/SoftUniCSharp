using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?<Day>\d{2})([-./])(?<Month>[A-Z][a-z]{2})\1(?<Year>\d{4})\b";
            string input = Console.ReadLine();
            MatchCollection validDates = Regex.Matches(input, regex);
            foreach (Match match in validDates)
            {
                string day = match.Groups["Day"].Value;
                string month = match.Groups["Month"].Value;
                string year = match.Groups["Year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}