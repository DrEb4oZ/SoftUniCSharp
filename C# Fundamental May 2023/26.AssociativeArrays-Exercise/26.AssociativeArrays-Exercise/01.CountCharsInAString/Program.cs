namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> inputCharCount = new Dictionary<char, int>();
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] == ' ')
            //    {
            //        continue;
            //    }

            //    if (!inputCharCount.ContainsKey(input[i]))
            //    {
            //        inputCharCount.Add(input[i], 0);
            //    }

            //    inputCharCount[input[i]]++;
            //}

            foreach (var character in input)
            {
                if (character == ' ')
                {
                    continue;
                }

                if (!inputCharCount.ContainsKey(character))
                {
                    inputCharCount.Add(character, 0);
                }

                inputCharCount[character]++;
            }

            foreach (var kvp in inputCharCount)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}