using System.Threading.Channels;

namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int synonymsCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> wordSynonymPairs = new Dictionary<string, List<string>>();
            for (int i = 0; i < synonymsCount; i++)
            {
                string currentWord = Console.ReadLine();
                string currentSynonym = Console.ReadLine();
                if (!wordSynonymPairs.ContainsKey(currentWord))
                {
                    wordSynonymPairs.Add(currentWord, new List<string>());
                }
                wordSynonymPairs[currentWord].Add(currentSynonym);
            }
            foreach (var kvp in wordSynonymPairs)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
            }
        }
    }
}