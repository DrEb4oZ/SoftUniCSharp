namespace _04.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();

            for (int i = inputWord.Length - 1; i >= 0; i--)
            {
                char currentChar = inputWord[i];
                Console.Write(currentChar);
            }
        }
    }
}