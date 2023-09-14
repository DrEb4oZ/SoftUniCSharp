using System.Text.RegularExpressions;
/*
2
!Send!:[IvanisHere]
*Time@:[Itis5amAlready]
*/
namespace _02.MessageTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stringCount = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < stringCount; i++)
            {
                string commandString = Console.ReadLine();
                string pattern = @"!(?<command>[A-Z][a-z]{2,})!:\[(?<string>[A-Za-z]{8,})\]";
                Regex regex = new Regex(pattern);
                MatchCollection validInput = Regex.Matches(commandString, pattern);
                if (regex.IsMatch(commandString))
                {
                    foreach (Match item in validInput)
                    {
                        Console.Write($"{item.Groups["command"].Value}: ");
                        List<int> charactersNumber = new List<int>();
                        foreach (char character in item.Groups["string"].Value)
                        {
                            charactersNumber.Add(character);
                        }
                        Console.WriteLine(string.Join(" ", charactersNumber));
                    }

                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }

            }
        }
    }
}