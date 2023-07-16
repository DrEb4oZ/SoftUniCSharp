using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"\b(?<FirstName>[A-Z][a-z]{1,}) (?<LastName>[A-Z][a-z]{1,})\b";

            MatchCollection matchNames = Regex.Matches(input, regex);

            foreach (Match match in matchNames)
            {
                Console.Write($"{match.Groups["FirstName"].Value} {match.Groups["LastName"].Value} ");
            }
        }
    }
}