using System.Text;

namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            decimal totalSum = 0m;
            for (int i = 0; i < input.Length; i++)
            {
                char[] currentInput = input[i].ToCharArray();
                int firstLetterPosition = 0;
                bool firstLetterCapital = true;
                int secondLetterPosition = 0;
                bool secondLetterCapital = true;
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < currentInput.Length; j++)
                {
                    if (currentInput[j] > 57 && currentInput[j] <= 90)
                    {
                        if (j == 0)
                        {
                            firstLetterPosition = LetterOperations(currentInput[0]);
                        }

                        else
                        {
                            secondLetterPosition = LetterOperations(currentInput[currentInput.Length - 1]);
                        }
                    }

                    else if (currentInput[j] > 57 && currentInput[j] > 90)
                    {
                        if (j == 0)
                        {
                            firstLetterPosition = LetterOperations(currentInput[0]);
                            firstLetterCapital = false;
                        }

                        else
                        {
                            secondLetterPosition = LetterOperations(currentInput[currentInput.Length - 1]);
                            secondLetterCapital = false;
                        }
                    }

                    else
                    {
                        sb.Append(currentInput[j]);
                    }
                }
                decimal currentResult = 0m;
                if (firstLetterCapital)
                {
                    currentResult = decimal.Parse(sb.ToString()) / firstLetterPosition;
                }

                else if (!firstLetterCapital)
                {
                    currentResult = decimal.Parse(sb.ToString()) * firstLetterPosition;
                }

                if (secondLetterCapital)
                {
                    currentResult -= secondLetterPosition;
                }

                else if (!secondLetterCapital)
                {
                    currentResult += secondLetterPosition;
                }

                totalSum += currentResult;
            }

            Console.WriteLine($"{totalSum:f2}");
        }


        private static int LetterOperations(int charPosition)
        {
            if (charPosition <= 90)
            {
                return charPosition - 64;
            }
            else
            {
                return charPosition - 96;
            }
        }
    }
}