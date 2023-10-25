using System.ComponentModel;

namespace _3.PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int sumDiagonal = 0;
            for (int row = 0; row < size; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[col, row] = currentRow[col];
                }
            }
            for (int i = 0; i < size; i++)
            {
                sumDiagonal += matrix[i, i];
            }

            Console.WriteLine(sumDiagonal);
        }
    }
}