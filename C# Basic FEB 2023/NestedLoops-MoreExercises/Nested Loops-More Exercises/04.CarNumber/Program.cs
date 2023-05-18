using System;

namespace _04.CarNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int finalNumber = int.Parse(Console.ReadLine());

            for (int i = startNumber; i <= finalNumber; i++)
            {
                for (int j = startNumber; j <= finalNumber; j++)
                {
                    for (int k = startNumber; k <= finalNumber; k++)
                    {
                        for (int l = startNumber; l <= finalNumber; l++)
                        {
                            if (i > l && ((i % 2 == 0 && l % 2 != 0) || (i % 2 != 0 && l % 2 == 0)) && (j + k) % 2 == 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
