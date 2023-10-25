using System.Diagnostics.CodeAnalysis;

namespace _3.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<int> numbers = new Stack<int>();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] != "+" && input[i] != "-")
                {
                    numbers.Push(int.Parse(input[i])); 
                }
            }
            int result = numbers.Pop();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == "+")
                {
                    result += numbers.Pop();
                }

                else if (input[i] == "-")
                {
                    result -= numbers.Pop();
                }
            }

            Console.WriteLine(result);
        }
    }
}