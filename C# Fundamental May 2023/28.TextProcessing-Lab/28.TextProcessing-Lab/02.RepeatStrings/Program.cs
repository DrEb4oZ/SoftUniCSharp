namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();
            string textResult = string.Empty;
            foreach (var word in input)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    textResult += word;
                }
            }

            Console.WriteLine(textResult);
        }
    }
}