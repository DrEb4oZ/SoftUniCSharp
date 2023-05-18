using System;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1111; i <= 9999; i++)
            {
                bool isSpecial = true;
                string currentNumber = i.ToString();

                for (int j = 0; j < currentNumber.Length && isSpecial; j++)
                {
                    int currentDigit = int.Parse(currentNumber[j].ToString());
                    if (currentDigit == 0 || number % currentDigit != 0)
                    {
                        isSpecial = false;
                    }
                }
                if (isSpecial)
                {
                    Console.Write(currentNumber + " ");
                }
            }
        }
    }
}
