using System.Text;

namespace _01.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            StringBuilder decryptedMessage = new StringBuilder(encryptedMessage);
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] commandTokens = command.Split("|");
                string currentCommand = commandTokens[0];
                switch (currentCommand)
                {
                    case "Move":
                        int lettersToMoveCount = int.Parse(commandTokens[1]);
                        decryptedMessage = MoveLetters(decryptedMessage, lettersToMoveCount);
                        break;
                    case "Insert":
                        int insertIndex = int.Parse(commandTokens[1]);
                        string stringToInsert = commandTokens[2];
                        decryptedMessage = InsertLetters(decryptedMessage, insertIndex, stringToInsert);
                        break;
                    case "ChangeAll":
                        string substring = commandTokens[1];
                        string replacement = commandTokens[2];
                        decryptedMessage = ChangeAll(decryptedMessage, substring, replacement);
                        break;
                }
            }
            Console.WriteLine($"The decrypted message is: {decryptedMessage.ToString()}");
        }

        private static StringBuilder ChangeAll(StringBuilder decryptedMessage, string substring, string replacement)
        {
            decryptedMessage.Replace(substring, replacement);
            return decryptedMessage;
        }

        private static StringBuilder InsertLetters(StringBuilder decryptedMessage, int insertIndex, string stringToInsert)
        {
            decryptedMessage.Insert(insertIndex, stringToInsert);
            return decryptedMessage;
        }

        private static StringBuilder MoveLetters(StringBuilder decryptedMessage, int lettersToMoveCount)
        {
            string tempString = decryptedMessage.ToString().Substring(0, lettersToMoveCount);
            decryptedMessage.Remove(0, lettersToMoveCount);
            decryptedMessage.Append(tempString);
            return decryptedMessage;
        }
    }
}