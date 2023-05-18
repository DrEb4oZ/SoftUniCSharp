using System;

namespace _06.RhombusOfStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = 1;
            int controlNumber = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < controlNumber - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < row; k++)
                {
                    Console.Write("* ");
                }
                row++;
                controlNumber--;
                Console.WriteLine();
            }
            controlNumber = n;
            row = n - 1;
            for (int k = n - 1; k > 0; k--)
            {
                for (int i = controlNumber - n; i >= 0; i--)
                {
                    Console.Write(" ");
                }
                for (int i = row - 1; i >= 0; i--)
                {
                    Console.Write("* ");
                }
                controlNumber++;
                row--;
                Console.WriteLine();
            }
        }
    }
}
