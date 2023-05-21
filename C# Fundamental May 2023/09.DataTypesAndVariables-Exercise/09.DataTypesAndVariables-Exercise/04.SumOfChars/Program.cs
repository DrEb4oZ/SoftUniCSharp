using System.Data.SqlTypes;

namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int charCount = int.Parse(Console.ReadLine());
            int charSum = 0;

            for (int i = 0; i < charCount; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                charSum += currentChar;
            }
            Console.WriteLine($"The sum equals: {charSum}");
        }
    }
}