using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool passwordCorrect = IsPasswordBetweenSinAnd10Chars(password) && IsPasswordOnlyLettersAndNumbers(password) && IsPasswordContainsTwoDigits(password);
            if (passwordCorrect)
            {
                Console.WriteLine("Password is valid");
            }

            else
            {
                if (!IsPasswordBetweenSinAnd10Chars(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (!IsPasswordOnlyLettersAndNumbers(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!IsPasswordContainsTwoDigits(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }

            }

        }

        static bool IsPasswordBetweenSinAnd10Chars(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsPasswordOnlyLettersAndNumbers(string password)
        {
            bool isValid = true;
            for (int i = 0; i < password.Length; i++)
            {
                if ((password[i] < 48 || password[i] > 57) && (password[i] < 65 || password[i] > 90) && (password[i] < 97 || password[i] > 122))
                {
                    isValid = false;
                }

            }

            return isValid;
        }

        static bool IsPasswordContainsTwoDigits(string password)
        {
            int digitsCount = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    digitsCount++;
                }

            }

            if (digitsCount >= 2)
            {
                return true;
            }

            else
            {
                return false;
            }

        }
    }
}