namespace _05.DecryptingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int keyNumber = int.Parse(Console.ReadLine());
            int lettersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < lettersCount; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                int decryptedChar = currentChar + keyNumber;
                Console.Write((char)decryptedChar);
            }
        }
    }
}