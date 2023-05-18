namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            char[] password = userName.ToCharArray();
            Array.Reverse(password);
            string correctPassword = new string(password);
            bool isPasswordValid = false;

            for (int i = 1; i <= 4 && !isPasswordValid; i++)
            {
                string pass = Console.ReadLine();
                if (pass == correctPassword)
                {
                    isPasswordValid = true;
                }
                else if (i < 4)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
            if (isPasswordValid)
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