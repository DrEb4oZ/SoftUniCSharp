using System.Data.Common;

namespace _6.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                int[] rowInput = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                jagged[row] = new int[rowInput.Length];
                for (int col = 0; col < rowInput.Length; col++)
                {
                    jagged[row][col] = rowInput[col];
                }
            }
            for (int row = 0; row < jagged.GetLength(0) - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }

                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;
                    }
                    for (int col2 =0; col2 < jagged[row+1].Length; col2++)
                    {
                        jagged[row + 1][col2] /= 2;
                    }
                }
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandTokens = command
                    .Split();
                string currentCommand = commandTokens[0];
                int currentRow = int.Parse(commandTokens[1]);
                int currentCol = int.Parse(commandTokens[2]);
                int value = int.Parse(commandTokens[3]);
                if (currentRow >= 0 && currentRow < jagged.GetLength(0) && currentCol >= 0 && currentCol < jagged[currentRow].Length)
                switch (commandTokens[0])
                {
                    case "Add":
                            jagged[currentRow][currentCol] += value;
                        break;
                    case "Subtract":
                            jagged[currentRow][currentCol] -= value;
                            break;
                }

                command = Console.ReadLine();
            }

            for (int row = 0; row < jagged.GetLength(0); row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}