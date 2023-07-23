using System.Text;
/*
Siiceercaroetavm!:?:ahsott.:i:nstupmomceqr
Cut 15 3
TakeOdd
Substitute :: -
Substitute | ^
Done
*/
namespace _01.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder password = new StringBuilder(input);
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] commandTokens = command
                    .Split();
                string currentCommand = commandTokens[0];
                switch (currentCommand)
                {
                    case "TakeOdd":
                        password = TakeOdd(password);
                        Console.WriteLine(password);
                        break;
                    case "Cut":
                        int startIndex = int.Parse(commandTokens[1]);
                        int stringLength = int.Parse(commandTokens[2]);
                        password = CutFirstOccurence(password, startIndex, stringLength);
                        Console.WriteLine(password);
                        break;
                    case "Substitute":
                        string substring = commandTokens[1];
                        string substitute = commandTokens[2];
                        if (password.ToString().Contains(substring))
                        {
                            password = SubstiteReplace(password, substring, substitute);
                            Console.WriteLine(password);
                        }

                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }

                        break;
                }
            }

            Console.WriteLine($"Your password is: {password}");
        }

        private static StringBuilder SubstiteReplace(StringBuilder password, string substring, string substitute)
        {
            password.Replace(substring, substitute);
            return password;
        }

        private static StringBuilder CutFirstOccurence(StringBuilder password, int startIndex, int stringLength)
        {
            password.Remove(startIndex, stringLength);
            return password;
        }

        private static StringBuilder TakeOdd(StringBuilder password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                password.Remove(i, 1);
            }
            return password;
        }
    }
}