using System;

namespace _14.PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (int k = 97; k < 97+l; k++)
                    {
                        for (int m = 97; m < 97 + l; m++)
                        {
                            if (i >= j)
                            {
                                for (int o = i + 1; o < n + 1; o++)
                                {
                                    Console.Write($"{i}{j}{(char)k}{(char)m}{o} ");
                                }
                            }
                            else if (j >= i)
                            {
                                for (int o = j + 1; o < n + 1; o++)
                                {
                                    Console.Write($"{i}{j}{(char)k}{(char)m}{o} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
