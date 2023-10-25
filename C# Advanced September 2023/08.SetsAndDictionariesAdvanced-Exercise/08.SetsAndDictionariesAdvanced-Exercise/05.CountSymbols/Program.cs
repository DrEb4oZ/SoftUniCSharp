namespace _05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char,int> everyCharCount = new SortedDictionary<char,int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!everyCharCount.ContainsKey(input[i]))
                {
                    everyCharCount.Add(input[i], 0);
                }

                everyCharCount[input[i]]++;
            }

            foreach (KeyValuePair<char,int> character in everyCharCount)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}