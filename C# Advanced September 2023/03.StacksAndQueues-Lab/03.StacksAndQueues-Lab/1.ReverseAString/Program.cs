namespace _1.ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reverseChar = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                reverseChar.Push(input[i]);
            }
            while(reverseChar.Count > 0)
            {
                Console.Write(reverseChar.Pop());
            }
        }
    }
}