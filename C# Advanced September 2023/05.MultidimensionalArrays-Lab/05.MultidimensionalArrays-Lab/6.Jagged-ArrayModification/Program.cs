namespace _6.Jagged_ArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                jagged[row] = currentRow;
                for (int col = 0; col < currentRow.Length; col++)
                {
                    jagged[row][col] = currentRow[col];
                }
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] commandTokens = command
                    .Split(' ');
                string currentCommand = commandTokens[0];
                int rowNumber = int.Parse(commandTokens[1]);
                int colNumber = int.Parse(commandTokens[2]);
                int value = int.Parse(commandTokens[3]);
                switch (currentCommand)
                {
                    case "Add":
                        if (rowNumber >= 0 && rowNumber < jagged.Length && colNumber >= 0 && colNumber < jagged[rowNumber].Length)
                        {
                            jagged[rowNumber][colNumber] += value;
                        }

                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }

                        break;

                    case "Subtract":
                        if (rowNumber >= 0 && rowNumber < jagged.Length && colNumber >= 0 && colNumber < jagged[rowNumber].Length)
                        {
                            jagged[rowNumber][colNumber] -= value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }

                        break;
                }

                command = Console.ReadLine();
            }

            for (int row = 0; row < rows; row++)
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