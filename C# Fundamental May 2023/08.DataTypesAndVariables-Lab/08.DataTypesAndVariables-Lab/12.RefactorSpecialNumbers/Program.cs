namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberCount; i++)
            {
                bool isNumberMagic = false;
                int currentNumber = i;
                int sumDigit = 0;
                while (currentNumber != 0)
                {
                    int currentDigit = currentNumber % 10;
                    sumDigit += currentDigit;
                    currentNumber = currentNumber / 10;
                }
                isNumberMagic = (sumDigit == 5) || (sumDigit == 7) || (sumDigit == 11);
                Console.WriteLine("{0} -> {1}", i, isNumberMagic);
            }
        }
    }
}