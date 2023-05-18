using System;

namespace _04.Sequence2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberRow = 1;
            while (numberRow <= n)
            {
                Console.WriteLine(numberRow);
                numberRow = numberRow * 2 + 1; 
            }
        }
    }
}
