using System;

namespace _13.PrimePairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValueFirstCouple = int.Parse(Console.ReadLine());
            int startValueSecondCouple = int.Parse(Console.ReadLine());
            int diffFristCouple = int.Parse(Console.ReadLine());
            int diffSecondCouple = int.Parse(Console.ReadLine());
            int counterFirstCouple = 0;
            bool isPrimeFirst = true;
            int counterSecondCouple = 0;
            bool isPrimeSecond = true;
            for (int i = startValueFirstCouple; i <= (startValueFirstCouple + diffFristCouple); i++)
            {
                isPrimeFirst = true;
                counterFirstCouple = 0;
                for (int k = 1; k < i && isPrimeFirst; k++)
                {
                    if (i % k == 0)
                    {
                        counterFirstCouple++;
                    }
                    if (counterFirstCouple > 1)
                    {
                        isPrimeFirst = false;
                    }
                }
                for (int j = startValueSecondCouple; j <= (startValueSecondCouple + diffSecondCouple) && isPrimeFirst; j++)
                {
                    isPrimeSecond = true;
                    counterSecondCouple = 0;
                    for (int l = 1; l < j && isPrimeSecond; l++)
                    {
                        if (j % l == 0)
                        {
                            counterSecondCouple++;
                        }
                        if (counterSecondCouple > 1)
                        {
                            isPrimeSecond = false;
                        }
                    }
                    if (isPrimeFirst && isPrimeSecond)
                    {
                        Console.WriteLine($"{i}{j}");
                    }
                }
            }
        }
    }
}
