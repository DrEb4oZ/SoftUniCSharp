namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberCount; i++)
            {
                int currentNumber = i;
                int sumDigits = 0;
                bool isNMagic = false;
                while(currentNumber != 0)
                {
                    int currentDigit = currentNumber % 10;
                    currentNumber /= 10;
                    sumDigits += currentDigit;
                }
                if (sumDigits == 5 || sumDigits == 7 || sumDigits == 11)
                {
                    isNMagic = true;
                }
                Console.WriteLine($"{i} -> {isNMagic}");
            }

        }
    }
}