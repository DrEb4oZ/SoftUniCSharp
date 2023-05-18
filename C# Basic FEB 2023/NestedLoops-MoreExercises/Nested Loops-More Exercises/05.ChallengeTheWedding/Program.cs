using System;

namespace _05.ChallengeTheWedding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maleCount = int.Parse(Console.ReadLine());
            int femaleCount = int.Parse(Console.ReadLine());
            int tableCount = int.Parse(Console.ReadLine());
            bool freeTabel = true;

            for (int i = 1; i <= maleCount && freeTabel; i++)
            {
                for (int j = 1; j <= femaleCount && freeTabel; j++)
                {
                    tableCount--;
                    Console.Write($"({i} <-> {j}) ");

                    if (tableCount == 0)
                    {
                        freeTabel = false;
                    }
                }
            }

        }
    }
}
