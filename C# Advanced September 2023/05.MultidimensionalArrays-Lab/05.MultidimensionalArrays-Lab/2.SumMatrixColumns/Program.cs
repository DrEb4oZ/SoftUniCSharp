namespace _2.SumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int rows = size[0];
            int cols = size[1];
            int[,] matrix = new int[rows, cols];
            int sumCols = 0;
            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            for (int col = 0; col < cols; col++)
            {
                int currentColSum = 0;
                for (int row = 0; row < rows; row++)
                {
                    currentColSum+= matrix[row, col];
                }

                Console.WriteLine(currentColSum);
            }
        }
    }
}