namespace _02.FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputCount; i++)
            {
                long sumNumber = 0;
                string numbers = Console.ReadLine();
                string[] numbersArraySplit = numbers.Split(' ');
                long firstNumber = long.Parse(numbersArraySplit[0]);
                long secondNumber = long.Parse(numbersArraySplit[1]);
                if (firstNumber >= secondNumber)
                {
                    while (firstNumber != 0)
                    {
                        long currentChar = firstNumber % 10;
                        sumNumber += currentChar;
                        firstNumber /= 10;
                    }

                }

                else if (firstNumber < secondNumber)
                {
                    while (secondNumber != 0)
                    {
                        long currentChar = secondNumber % 10;
                        sumNumber += currentChar;
                        secondNumber /= 10;
                    }

                }

                Console.WriteLine(Math.Abs(sumNumber));
            }
        }
    }
}