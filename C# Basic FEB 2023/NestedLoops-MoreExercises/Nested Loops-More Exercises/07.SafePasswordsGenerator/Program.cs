using System;

namespace _07.SafePasswordsGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPasswordsCount = int.Parse(Console.ReadLine());
            int passwordCount = 0;
            bool maxPasswordCountReached = false;
            int firstSymbol = 35;
            int secondSymbol = 64;
            for (int k = 1; k <= a && !maxPasswordCountReached; k++)
            {
                for (int l = 1; l <= b && !maxPasswordCountReached; l++)
                {
                    Console.Write($"{(char)firstSymbol}{(char)secondSymbol}{k}{l}{(char)secondSymbol}{(char)firstSymbol}|");
                    firstSymbol++;
                    if (firstSymbol == 56)
                    {
                        firstSymbol = 35;
                    }
                    secondSymbol++;
                    if (secondSymbol == 97)
                    {
                        secondSymbol = 64;
                    }
                    passwordCount++;
                    if (passwordCount == maxPasswordsCount)
                    {
                        maxPasswordCountReached = true;
                    }
                }
            }
        }
    }
}
