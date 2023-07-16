using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regexMessage = @"@(?<planet>[A-Za-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<attackType>A|D)[^@\-!:>]*![^@\-!:>]*->[^@\-!:>]*?(?<soldierCount>\d+)";
            int messagesCount = int.Parse(Console.ReadLine());
            StringBuilder decryptedInput = new StringBuilder();
            List<Message> messages = new List<Message>();
            int attackedPlanetCount = 0;
            int destroyedPlanetCount = 0;
            for (int i = 0; i < messagesCount; i++)
            {
                string input = Console.ReadLine();
                int decryptionKey = 0;
                foreach (char character in input)
                {
                    if (character == 'A' || character == 'a' || character == 'S' || character == 's' || character == 'T' || character == 't' || character == 'R' || character == 'r')
                    {
                        decryptionKey++;
                    }
                }

                foreach (char character in input)
                {
                    decryptedInput.Append((char)(character - decryptionKey));
                }
            }

            MatchCollection validMessages = Regex.Matches(decryptedInput.ToString(), regexMessage);
            foreach (Match message in validMessages)
            {
                Message currentMessage = new Message();
                currentMessage.PlanetName = message.Groups["planet"].Value;
                currentMessage.Population = int.Parse(message.Groups["population"].Value);
                currentMessage.AttackType = char.Parse(message.Groups["attackType"].Value);
                currentMessage.SoldierCount = int.Parse(message.Groups["soldierCount"].Value);
                messages.Add(currentMessage);
                if (currentMessage.AttackType == 'A')
                {
                    attackedPlanetCount++;
                }
                else if (currentMessage.AttackType == 'D')
                {
                    destroyedPlanetCount++;
                }
            }
            List<Message> orderedMessages = messages
                .OrderBy(x => x.PlanetName)
                .ToList();
            Console.WriteLine($"Attacked planets: {attackedPlanetCount}");
            foreach (Message message in orderedMessages)
            {
                if (message.AttackType == 'A')
                {
                    Console.WriteLine($"-> {message.PlanetName}");
                }
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanetCount}");
            foreach (Message message in orderedMessages)
            {
                if (message.AttackType == 'D')
                {
                    Console.WriteLine($"-> {message.PlanetName}");
                }
            }
        }
    }
    public class Message
    {
        public string PlanetName { get; set; }
        public int Population { get; set; }
        public char AttackType { get; set; }
        public int SoldierCount { get; set; }
    }
}