namespace _4.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();  //1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5
            Stack<int> indexes = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (input[i] == ')')
                {
                    int tempIndex = indexes.Pop();
                    Console.WriteLine(input.Substring(tempIndex, i - tempIndex + 1));
                }
            }
        }
    }
}