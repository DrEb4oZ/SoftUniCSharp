namespace _8.Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int row = 0; row < size; row++)
            {
                int[] rowInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row,col] = rowInput[col];
                }
            }

            string[] coordinates = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < coordinates.Length; i++)
            {
                int[] currentCoordiantes = coordinates[i]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int currentBombRow = currentCoordiantes[0];
                int currentBombCol = currentCoordiantes[1];
                if (currentBombRow >= 0 && currentBombRow < matrix.GetLength(0) && currentBombCol >= 0 && currentBombCol < matrix.GetLength(1) && matrix[currentBombRow, currentBombCol] > 0)
                {
                    if (isValidIndexes(size, currentBombRow - 1, currentBombCol - 1) && matrix[currentBombRow - 1, currentBombCol - 1] > 0)
                    {
                        matrix[currentBombRow - 1, currentBombCol - 1] -= matrix[currentBombRow, currentBombCol];
                    }

                    if (isValidIndexes(size, currentBombRow, currentBombCol - 1) && matrix[currentBombRow, currentBombCol - 1] > 0)
                    {
                        matrix[currentBombRow, currentBombCol - 1] -= matrix[currentBombRow, currentBombCol];
                    }

                    if (isValidIndexes(size, currentBombRow + 1, currentBombCol - 1) && matrix[currentBombRow + 1, currentBombCol - 1] > 0)
                    {
                        matrix[currentBombRow + 1, currentBombCol - 1] -= matrix[currentBombRow, currentBombCol];
                    }

                    if (isValidIndexes(size, currentBombRow + 1, currentBombCol) && matrix[currentBombRow + 1, currentBombCol] > 0)
                    {
                        matrix[currentBombRow + 1, currentBombCol] -= matrix[currentBombRow, currentBombCol];
                    }

                    if (isValidIndexes(size, currentBombRow + 1, currentBombCol + 1) && matrix[currentBombRow + 1, currentBombCol + 1] > 0)
                    {
                        matrix[currentBombRow + 1, currentBombCol + 1] -= matrix[currentBombRow, currentBombCol];
                    }

                    if (isValidIndexes(size, currentBombRow, currentBombCol + 1) && matrix[currentBombRow, currentBombCol + 1] > 0)
                    {
                        matrix[currentBombRow, currentBombCol + 1] -= matrix[currentBombRow, currentBombCol];
                    }

                    if (isValidIndexes(size, currentBombRow - 1, currentBombCol + 1) && matrix[currentBombRow - 1, currentBombCol + 1] > 0)
                    {
                        matrix[currentBombRow - 1, currentBombCol + 1] -= matrix[currentBombRow, currentBombCol];
                    }

                    if (isValidIndexes(size, currentBombRow - 1, currentBombCol) && matrix[currentBombRow - 1, currentBombCol] > 0)
                    {
                        matrix[currentBombRow - 1, currentBombCol] -= matrix[currentBombRow, currentBombCol];
                    }
                    matrix[currentBombRow, currentBombCol] = 0;
                }
            }
            int sumAliveCells = 0;
            int aliveCellsCount = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        sumAliveCells += matrix[row, col];
                        aliveCellsCount++;
                    }
                }
            }
            Console.WriteLine($"Alive cells: {aliveCellsCount}");
            Console.WriteLine($"Sum: {sumAliveCells}");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
        private static bool isValidIndexes(int size, int row, int col)
        {
            return row >= 0 && row < size && col >= 0 && col < size;
        }
    }
}