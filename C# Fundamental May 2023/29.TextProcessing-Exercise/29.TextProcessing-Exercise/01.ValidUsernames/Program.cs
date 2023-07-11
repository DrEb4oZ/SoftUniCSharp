namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine()
                .Split(", ");
            foreach (var user in userNames)
            {
                if (user.Length >= 3 && user.Length <= 16 && user.All(x => char.IsDigit(x) || char.IsLetter(x) || x == '_' || x == '-'))
                {
                    Console.WriteLine(user);
                }
            }
        }
    }
}