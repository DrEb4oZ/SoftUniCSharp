using System.Text;

namespace _01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();
            string command = string.Empty;
            StringBuilder message = new StringBuilder(concealedMessage);
            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] commandTokens = command
                    .Split(":|:");
                string currentCommand = commandTokens[0];
                switch (currentCommand)
                {
                    case "InsertSpace":
                        int index = int.Parse(commandTokens[1]);
                        InsertSpace(message, index);
                        break;
                    case "Reverse":
                        string substringValue = commandTokens[1];
                        ReverseAndAdd(message, substringValue);
                        break;
                    case "ChangeAll":
                        string substringToReplace = commandTokens[1];
                        string replacemet = commandTokens[2];
                        ChangeString(message, substringToReplace, replacemet);
                        break;
                }
            }

            Console.WriteLine($"You have a new text message: {message.ToString()}");
        }

        private static void ChangeString(StringBuilder message, string substringToReplace, string replacemet)
        {
            message.Replace(substringToReplace, replacemet);
            Console.WriteLine(message.ToString());
        }

        private static void ReverseAndAdd(StringBuilder message, string substringValue)
        {

            if (message.ToString().Contains(substringValue))
            {
                int startIndex = message.ToString().IndexOf(substringValue);
                message.Remove(startIndex, substringValue.Length);
                message.Append(new string(substringValue.Reverse().ToArray()));
                Console.WriteLine(message.ToString());
            }

            else
            {
                Console.WriteLine("error");
            }
        }

        private static void InsertSpace(StringBuilder message, int index)
        {
            message.Insert(index, ' ');
            Console.WriteLine(message.ToString());
        }
    }
}