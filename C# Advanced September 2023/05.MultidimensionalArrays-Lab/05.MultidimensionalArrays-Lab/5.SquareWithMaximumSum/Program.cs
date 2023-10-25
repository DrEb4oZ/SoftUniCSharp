namespace _5.SquareWithMaximumSum
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
            for (int row = 0; row < rows; row++)
            {
                int[] rowInput = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }

            int biggestSum = int.MinValue;
            int bestNumber1 = 0;
            int bestNumber2 = 0;
            int bestNumber3 = 0; 
            int bestNumber4 = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                    if (currentSum > biggestSum)
                    {
                        biggestSum = currentSum;
                        bestNumber1 = matrix[row, col];
                        bestNumber2 = matrix[row, col + 1];
                        bestNumber3 = matrix[row + 1, col];
                        bestNumber4 = matrix[row + 1, col + 1];
                    }
                }
            }

            Console.WriteLine($"{bestNumber1} {bestNumber2}");
            Console.WriteLine($"{bestNumber3} {bestNumber4}");
            Console.WriteLine(biggestSum);
        }
    }
}