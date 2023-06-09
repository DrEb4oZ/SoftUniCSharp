namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMultipleOfEvenAndOdds(inputNumber));
        }

        static int GetMultipleOfEvenAndOdds(int inputNumber)
        {
            return GetSumOfEvenDigits(inputNumber) * etSumOfOddDigits(inputNumber);
        }

        static int etSumOfOddDigits(int inputNumber)
        {
            int sumOdds = 0;
            while (inputNumber != 0)
            {
                int currentNumber = inputNumber % 10;
                if (currentNumber % 2 != 0)
                {
                sumOdds += currentNumber;
                }

                inputNumber /= 10;
            }

            return sumOdds;
        }

        static int GetSumOfEvenDigits(int inputNumber)
        {
            int sumEven = 0;
            while (inputNumber != 0)
            {
                int currentNumber = inputNumber % 10;
                if (currentNumber % 2 == 0)
                {
                sumEven += currentNumber;
                }

                inputNumber /= 10;
            }

            return sumEven;
        }
    }
}