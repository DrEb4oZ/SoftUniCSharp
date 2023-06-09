namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberInput; i++)
            {
                if (HoldAtLesastOneOddDigit(i) && SumOfDigitsDivideBy8(i))
                {
                Console.WriteLine(i);
                }

            }
        }

        static bool HoldAtLesastOneOddDigit(int number)
        {
            bool consistOddDigit = false;
            while (number != 0)
            {
                int currentNumber = number % 10;
                if (currentNumber % 2 != 0)
                {
                    consistOddDigit = true;
                }

                number /= 10;
            }

            return consistOddDigit;
        }

        static bool SumOfDigitsDivideBy8(int number)
        {
            int sumOfDigits = 0;
            while (number != 0)
            {
                int currentNumber = number % 10;
                sumOfDigits += currentNumber;
                number /= 10;
            }

            return sumOfDigits % 8 == 0;
        }
    }
}