using System.ComponentModel.DataAnnotations;
using System.Text;
namespace _01.Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command = string.Empty;
            StringBuilder passowrdResult = new StringBuilder(password);
            while ((command = Console.ReadLine()) != "Complete")
            {
                string[] commandTokens = command
                    .Split();
                string currentCommand = commandTokens[0];
                switch (currentCommand)
                {
                    case "Make":
                        string upperOrLower = commandTokens[1];
                        int indexCommandMake = int.Parse(commandTokens[2]);
                        Make(passowrdResult, upperOrLower, indexCommandMake);
                        break;
                    case "Insert":
                        int indexCommandInsert = int.Parse(commandTokens[1]);
                        char characterCommandInsert = char.Parse(commandTokens[2]);
                        Insert(passowrdResult, indexCommandInsert, characterCommandInsert);
                        break;
                    case "Replace":
                        char characterCommandReplace = char.Parse(commandTokens[1]);
                        int valueToAddToCharASCII = int.Parse(commandTokens[2]);
                        Replace(passowrdResult, characterCommandReplace, valueToAddToCharASCII);
                        break;
                    case "Validation":
                        Validation(passowrdResult);
                        break;
                }
            }
        }

        private static void Validation(StringBuilder passowrdResult)
        {
            if (passowrdResult.Length < 8)
            {
                Console.WriteLine("Password must be at least 8 characters long!");
            }

            if (!passowrdResult.ToString().All(x => char.IsLetterOrDigit(x) || x == '_'))
            {
                Console.WriteLine("Password must consist only of letters, digits and _!");
            }

            if (!passowrdResult.ToString().Any(x => char.IsUpper(x)))
            {
                Console.WriteLine("Password must consist at least one uppercase letter!");
            }

            if (!passowrdResult.ToString().Any(x => char.IsLower(x)))
            {
                Console.WriteLine("Password must consist at least one lowercase letter!");
            }

            if (!passowrdResult.ToString().Any(x => char.IsDigit(x)))
            {
                Console.WriteLine("Password must consist at least one digit!");
            }
        }

        private static void Replace(StringBuilder passowrdResult, char characterCommandReplace, int valueToAddToCharASCII)
        {
            if ((characterCommandReplace + valueToAddToCharASCII) >= 0 && (characterCommandReplace + valueToAddToCharASCII) <= 255)
            {
                if (passowrdResult.ToString().Contains(characterCommandReplace))
                {
                    passowrdResult.Replace(characterCommandReplace, (char)(characterCommandReplace + valueToAddToCharASCII));
                    Console.WriteLine(passowrdResult.ToString());
                }
            }
        }

        private static void Insert(StringBuilder passowrdResult, int indexCommandInsert, char characterCommandInsert)
        {
            if (indexCommandInsert >= 0 && indexCommandInsert < passowrdResult.Length)
            {
                passowrdResult.Insert(indexCommandInsert, characterCommandInsert);
                Console.WriteLine(passowrdResult.ToString());
            }
        }

        private static void Make(StringBuilder passowrdResult, string upperOrLower, int indexCommandMake)
        {
            if (indexCommandMake >= 0 && indexCommandMake < passowrdResult.Length && char.IsLetter(passowrdResult[indexCommandMake]))
            {
                if (upperOrLower == "Upper" && passowrdResult[indexCommandMake] >= 97 && passowrdResult[indexCommandMake] <= 122)
                {
                    string tempChar = passowrdResult[indexCommandMake].ToString().ToUpper();
                    passowrdResult.Remove(indexCommandMake, 1);
                    passowrdResult.Insert(indexCommandMake, tempChar);
                }

                else if (upperOrLower == "Lower" && passowrdResult[indexCommandMake] >= 65 && passowrdResult[indexCommandMake] <= 90)
                {
                    string tempChar = passowrdResult[indexCommandMake].ToString().ToLower();
                    passowrdResult.Remove(indexCommandMake, 1);
                    passowrdResult.Insert(indexCommandMake, tempChar);
                }

                Console.WriteLine(passowrdResult.ToString());
            }
        }
    }
}