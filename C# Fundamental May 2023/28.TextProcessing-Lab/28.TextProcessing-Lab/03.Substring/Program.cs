namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToRemoe = Console.ReadLine();
            string word = Console.ReadLine();
            while (word.Contains(wordToRemoe))
            {
                int wordToRemoveIndex = word.IndexOf(wordToRemoe);
                word = word.Remove(wordToRemoveIndex, wordToRemoe.Length);
            }

            Console.WriteLine(word);
        }
    }
}