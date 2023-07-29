using System.Numerics;
using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string validEmojis = @"([:]{2}|[*]{2})(?<emoji>[A-Z][a-z]{2,})\1";
            string allDigits = @"\d";
            BigInteger coolTreshhold = 1;
            foreach (Match match in Regex.Matches(input,allDigits))
            
            {
                coolTreshhold *= BigInteger.Parse(match.Value);
            }

            if (Regex.Matches(input, allDigits).Count == 0)
            {
                coolTreshhold = 0;
            }

            int emojiCount = Regex.Matches(input, validEmojis).Count;
            List<string> coolEmojis = new List<string>();
            foreach (Match match in Regex.Matches(input, validEmojis))
            {
                BigInteger currentEmojiCoolnes = 0;
                foreach (char character in match.Groups["emoji"].Value)
                {
                    currentEmojiCoolnes += character;
                }

                if (currentEmojiCoolnes >= coolTreshhold)
                {
                    coolEmojis.Add(match.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {coolTreshhold}");
            Console.WriteLine($"{emojiCount} emojis found in the text. The cool ones are:");
            foreach (var item in coolEmojis)
            {
                Console.WriteLine(item);
            }
        }
    }
}