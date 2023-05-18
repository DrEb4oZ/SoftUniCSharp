using System;

namespace _10.Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count1Lv = int.Parse(Console.ReadLine());
            int count2Lv = int.Parse(Console.ReadLine());
            int count5Lv = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= count1Lv; i++)
            {
                for (int j = 0; j <= count2Lv; j++)
                {
                    for (int k = 0; k <= count5Lv; k++)
                    {
                        if (i * 1 + j * 2 + k * 5 == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
