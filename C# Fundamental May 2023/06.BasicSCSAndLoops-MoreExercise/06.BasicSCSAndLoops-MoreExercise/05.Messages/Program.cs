namespace _05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wordLenght = int.Parse(Console.ReadLine());
            int numberOfDigitsCounter = 0;
            for (int i = 0; i < wordLenght; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int numberDigit = number;
                if (number == 0)
                {
                    Console.Write(" ");
                }

                else
                {
                    for (int j = 0; j < number.ToString().Length; j++)
                    {
                        numberOfDigitsCounter++;
                        if (j > 0) numberDigit /= 10;
                    }

                    int numberOffset = (numberDigit - 2) * 3;
                    if (numberDigit == 8 || numberDigit == 9)
                    {
                        numberOffset++;
                    }

                    int numberIndex = numberOffset + numberOfDigitsCounter - 1;
                    int digit = numberIndex + 97;

                    Console.Write((char)digit);
                }

                numberOfDigitsCounter = 0;
            }
        }
    }
}