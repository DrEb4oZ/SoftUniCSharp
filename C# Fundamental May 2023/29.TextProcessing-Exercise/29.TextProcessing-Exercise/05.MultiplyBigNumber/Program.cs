using System.Text;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            char secondNumber = char.Parse(Console.ReadLine());
            int secondNumberIntValue = secondNumber - 48;
            StringBuilder result = new StringBuilder();
            StringBuilder finalResult = new StringBuilder();
            int reminder = 0;
            if (secondNumberIntValue == 0)
            {
                finalResult.Append(0);
            }

            else
            {
                for (int i = firstNumber.Length - 1; i >= 0; i--)
                {
                    int currentNumber = firstNumber[i] - 48;
                    int currentDigit = secondNumberIntValue * currentNumber + reminder;
                    result.Append(currentDigit % 10);
                    reminder = currentDigit / 10;
                }

                if (reminder != 0)
                {
                    result.Append(reminder);
                }

                for (int i = result.Length - 1; i >= 0; i--)
                {
                    finalResult.Append(result[i]);
                }
            }

            Console.WriteLine(finalResult);
        }
    }
}