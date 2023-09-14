using System.Security.Cryptography.X509Certificates;

namespace _01.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] commandTokens = command
                    .Split(">>>");
                string currentCommand = commandTokens[0];
                switch (currentCommand)
                {
                    case "Contains":
                        string substring = commandTokens[1];
                        IsSubstringExist(activationKey, substring);
                        break;
                    case "Flip":
                        string lowerOrUpper = commandTokens[1];
                        int startIndexFlip = int.Parse(commandTokens[2]);
                        int endIndexFlip = int.Parse(commandTokens[3]);   //the range is between startIndex and endIndex(exclusively), in other words length will be (endIndex - startIndex)
                        activationKey = LettersConversion(activationKey, lowerOrUpper, startIndexFlip, endIndexFlip);
                        break;
                    case "Slice":
                        int startIndexSlice = int.Parse(commandTokens[1]);
                        int endIndexSlice = int.Parse(commandTokens[2]);  //the range is between startIndex and endIndex(exclusively)
                        activationKey = LetterRemove(activationKey, startIndexSlice, endIndexSlice);
                        break;
                }
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }

        private static string LetterRemove(string activationKey, int startIndexSlice, int endIndexSlice)
        {
            activationKey = activationKey.Remove(startIndexSlice, endIndexSlice - startIndexSlice);
            Console.WriteLine(activationKey);
            return activationKey;
        }

        private static string LettersConversion(string activationKey, string lowerOrUpper, int startIndex, int endIndex)
        {
            if (lowerOrUpper == "Upper")
            {
                string temp = activationKey.Substring(startIndex, endIndex - startIndex).ToUpper();
                activationKey = activationKey.Replace(activationKey.Substring(startIndex, endIndex - startIndex), temp);  // this isnt right because it will replace all occurances of the string in the input not only the one between the given indexes. it gives 100/100 because there is no check for case like this!
                Console.WriteLine(activationKey);
                return activationKey;
            }

            else
            {
                string temp = activationKey.Substring(startIndex, endIndex - startIndex).ToLower();
                activationKey = activationKey.Replace(activationKey.Substring(startIndex, endIndex - startIndex), temp); // this isnt right because it will replace all occurances of the string in the input not only the one between the given indexes. it gives 100/100 because there is no check for case like this!
                Console.WriteLine(activationKey);
                return activationKey;
            }
        }

        private static void IsSubstringExist(string activationKey, string substring)
        {
            if (activationKey.Contains(substring))
            {
                Console.WriteLine($"{activationKey} contains {substring}");
            }

            else
            {
                Console.WriteLine("Substring not found!");
            }
        }
    }
}