namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            bool isPasswordCharValid = false;
            bool wrongPassword = false;

            for (int i = 1; i <= 4 && !isPasswordCharValid; i++)
            {
                wrongPassword = false;
                string pass = Console.ReadLine();
                for (int j = userName.Length - 1; j >= 0 && !isPasswordCharValid &&!wrongPassword; j--)
                {
                    char currentCorrectPasswordChar = userName[j];
                    for (int k = 0; k < pass.Length && !isPasswordCharValid && !wrongPassword; k++)
                    {
                        if (userName.Length == pass.Length)
                        {
                            char currentInputPassChar = pass[k];

                            if (currentInputPassChar == currentCorrectPasswordChar)
                            {
                                isPasswordCharValid = true;
                            }
                            else if (i < 4)
                            {
                                Console.WriteLine("Incorrect password. Try again.");
                                wrongPassword = true;
                            }
                            else if (i == 4)
                            {
                                wrongPassword = true;
                            }
                            j--;
                            currentCorrectPasswordChar = userName[j];
                        }
                        else
                        {
                            if (i < 4)
                            {
                                Console.WriteLine("Incorrect password. Try again.");
                                wrongPassword = true;
                            }
                            else if (i == 4)
                            {
                                wrongPassword = true;
                            }
                        }
                    }
                }
            }
            if (isPasswordCharValid)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
            else
            {
                Console.WriteLine($"User {userName} blocked!");
            }
        }
    }
}