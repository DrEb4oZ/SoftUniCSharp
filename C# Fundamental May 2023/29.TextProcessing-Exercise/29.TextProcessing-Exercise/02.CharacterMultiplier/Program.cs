using System.Diagnostics.CodeAnalysis;

namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();
            int result = StringCharsMultiply(input[0], input[1]);
            Console.WriteLine(result);

        }
        private static int StringCharsMultiply(string firstString, string secondString)
        {
            int sum = 0;
            int length = Math.Min(firstString.Length, secondString.Length);
            for (int i = 0; i < length; i++)
            {
                sum += firstString[i] * secondString[i];
            }

            sum += SumOfExcesiveChars(firstString, secondString);
            return sum;
        }
        private static int SumOfExcesiveChars(string firstString, string secondString)
        {
            int sum = 0;
            if (firstString.Length > secondString.Length)
            {
                for (int i = secondString.Length; i < firstString.Length; i++)
                {
                    sum += firstString[i];
                }
            }

            else
            {
                for (int i = firstString.Length; i < secondString.Length; i++)
                {
                    sum += secondString[i];
                }
            }

            return sum;
        }
    }
}