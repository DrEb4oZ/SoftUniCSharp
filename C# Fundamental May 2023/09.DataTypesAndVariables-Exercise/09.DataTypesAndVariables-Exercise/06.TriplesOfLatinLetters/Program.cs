namespace _06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int charCount = int.Parse(Console.ReadLine());
            int startChar = 97;
            int endChar = 97 + charCount;

            for (int i = startChar; i < endChar; i++)
            {
                for (int j = startChar; j < endChar; j++)
                {
                    for (int k = startChar; k < endChar; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}