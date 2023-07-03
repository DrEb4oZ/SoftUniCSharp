namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wordsInput = Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0)
                .ToArray();

            foreach (var word in wordsInput)
            {
                Console.WriteLine(word);
            }
        }
    }
}