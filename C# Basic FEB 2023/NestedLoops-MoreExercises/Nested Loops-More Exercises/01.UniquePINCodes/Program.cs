using System;

namespace _01.UniquePINCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1Ceiling = int.Parse(Console.ReadLine());
            int num2Ceiling = int.Parse(Console.ReadLine());
            int num3Ceiling = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= num1Ceiling; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 1; j <= num2Ceiling; j++)
                    {
                        int countControlNumber = 0;
                        for (int k = 2; k <= j; k++)
                        {
                            if (j % k == 0)
                            {
                                countControlNumber++;
                            }
                        }
                        if (countControlNumber == 1)
                        {
                            for (int l = 1; l <= num3Ceiling; l++)
                            {
                                if (l % 2 == 0)
                                {
                                    Console.WriteLine($"{i} {j} {l}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
