using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"([@|#])(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1";
            MatchCollection wordPairs = Regex.Matches(input, regex);
            int pairCount = 0;
            int mirrorWordsCount = 0;
            List<string> mirrorWords = new List<string>();
            foreach (Match match in wordPairs)
            {
                pairCount++;
                string reverseSecondWord = new string(match.Groups["secondWord"].Value.Reverse().ToArray());
                if (match.Groups["firstWord"].Value == reverseSecondWord)
                {
                    mirrorWordsCount++;
                    string currentMirrorWord = $"{match.Groups["firstWord"]} <=> {match.Groups["secondWord"]}";
                    mirrorWords.Add(currentMirrorWord);
                }
            }
            if (pairCount == 0)
            {
                Console.WriteLine("No word pairs found!\nNo mirror words!");
            }
            else if (pairCount > 0 && mirrorWordsCount == 0)
            {
                Console.WriteLine($"{pairCount} word pairs found!\nNo mirror words!");
            }
            else
            {
                Console.WriteLine($"{pairCount} word pairs found!\nThe mirror words are:\n" + string.Join(", ", mirrorWords));
            }
        }
    }
}