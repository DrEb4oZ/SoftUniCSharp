namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wordsInput = Console.ReadLine()
                .ToLower()
                .Split()
                .ToArray();
            Dictionary<string, int> wordsInputCount = new Dictionary<string, int>();

            for (int i = 0; i < wordsInput.Length; i++)
            {
                if (!wordsInputCount.ContainsKey(wordsInput[i]))
                {
                    wordsInputCount.Add(wordsInput[i], 0);
                }
                wordsInputCount[wordsInput[i]]++;
            }

            foreach (var word in wordsInputCount)
            {
                if (word.Value % 2 != 0)
                Console.Write(word.Key + " ");
            }
        }
    }
}