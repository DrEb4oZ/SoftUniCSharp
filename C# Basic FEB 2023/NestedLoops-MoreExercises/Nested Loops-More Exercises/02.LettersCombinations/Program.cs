using System;

namespace _02.LettersCombinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char row1 = char.Parse(Console.ReadLine());
            char row2 = char.Parse(Console.ReadLine());
            char row3 = char.Parse(Console.ReadLine());
            int countValidCombo = 0;

            for (int i = row1; i <= row2; i++)
            {
                if (i != row3)
                {
                    for (int j = row1; j <= row2; j++)
                    {
                        if (j != row3)
                        {
                            for (int k = row1; k <= row2; k++)
                            {
                                if (k != row3)
                                {
                                    char char1 = (char)i;
                                    char char2 = (char)j;
                                    char char3 = (char)k;
                                    countValidCombo++;

                                    Console.Write($"{char1}{char2}{char3} ");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(countValidCombo);
        }
    }
}
