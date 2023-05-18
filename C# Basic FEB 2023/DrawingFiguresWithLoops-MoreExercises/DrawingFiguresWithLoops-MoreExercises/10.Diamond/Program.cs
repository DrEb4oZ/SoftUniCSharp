using System;

namespace _10.Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int controlNumber = n;
            int controlNumber2 = 1;
            {
                if (n % 2 == 0)
                {
                    for (int j = 0; j < n / 2; j++)
                    {
                        for (int i = 0; i < (controlNumber - 1) / 2; i++)
                        {
                            Console.Write("-");
                        }
                        if (controlNumber2 == 1)
                        {
                            Console.Write("**");
                        }
                        if (controlNumber2 > 1)
                        {
                            Console.Write("*");
                        }
                        for (int i = 0; i < controlNumber2 - 1; i++)
                        {
                            Console.Write("-");
                        }
                        if (controlNumber2 > 1)
                        {
                            Console.Write("*");
                        }
                        for (int i = 0; i < (controlNumber - 1) / 2; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine();
                        controlNumber -= 2;
                        controlNumber2 += 2;
                    }
                    controlNumber = n;
                    controlNumber2 = n -1;
                    for (int i = n / 2 - 2; i >= 0; i--)
                    {
                        for (int j = controlNumber - n; j >= 0; j--)
                        {
                            Console.Write("-");
                        }
                        Console.Write("*");
                        for (int j = controlNumber2 - 4; j >= 0; j--)
                        {
                            Console.Write("-");
                        }
                            Console.Write("*");
                        for (int j = controlNumber - n; j >= 0; j--)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine();
                        controlNumber++;
                        controlNumber2 -= 2;
                    }
                }
                else if (n % 2 != 0)
                {
                    for (int j = 0; j < n / 2 + 1; j++)
                    {
                        for (int i = 0; i < (controlNumber - 1) / 2; i++)
                        {
                            Console.Write("-");
                        }
                        if (controlNumber2 == 1)
                        {
                            Console.Write("*");
                        }
                        if (controlNumber2 > 1)
                        {
                            Console.Write("*");
                        }
                        for (int i = 0; i < controlNumber2 - 2; i++)
                        {
                            Console.Write("-");
                        }
                        if (controlNumber2 > 1)
                        {
                            Console.Write("*");
                        }
                        for (int i = 0; i < (controlNumber - 1) / 2; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine();
                        controlNumber -= 2;
                        controlNumber2 += 2;
                    }
                    controlNumber = n;
                    controlNumber2 = n - 1;
                    for (int i = n / 2 - 1; i >= 0; i--)
                    {
                        for (int j = controlNumber - n; j >= 0; j--)
                        {
                            Console.Write("-");
                        }
                        if (controlNumber / 3 != n / 2)
                        {
                            Console.Write("*");
                        }
                        for (int j = controlNumber2 - 4; j >= 0; j--)
                        {
                            Console.Write("-");
                        }
                        Console.Write("*");
                        for (int j = controlNumber - n; j >= 0; j--)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine();
                        controlNumber++;
                        controlNumber2 -= 2;
                    }
                }
            }
        }
    }
}
