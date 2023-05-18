using System;

namespace _12.TheSongOfTheWheels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            string correctPassword = "";
            bool isValid = false;

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            if (i < j && k > l && i*j + k*l == controlNumber)
                            {
                                counter++;
                                if (counter == 4)
                                {
                                    correctPassword = ($"{i}{j}{k}{l}");
                                    isValid = true;
                                }
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            if (!isValid)
            {
                Console.WriteLine("No!");
            }
            else
            {
                Console.WriteLine($"Password: {correctPassword}");
            }
        }
    }
}
