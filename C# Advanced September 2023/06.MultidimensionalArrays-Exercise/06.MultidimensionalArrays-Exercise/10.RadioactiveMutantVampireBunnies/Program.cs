using System.ComponentModel;

namespace _10.RadioactiveMutantVampireBunnies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] field = new char[rows, cols];
            int currentRow = 0;
            int currentCol = 0;
            for (int row = 0; row < rows; row++)
            {
                string rowInput = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    field[row, col] = rowInput[col];
                    if (field[row, col] == 'P')
                    {
                        currentRow = row;
                        currentCol = col;
                        field[row, col] = '.';
                    }
                }
            }
            string directions = Console.ReadLine();
            bool isPlayerOut = false;
            bool isBunnyHit = false;
            for (int i = 0; i < directions.Length && !isPlayerOut && !isBunnyHit; i++)
            {
                char currentDirection = directions[i];
                if (currentDirection == 'U')
                {
                    if (currentRow - 1 >= 0)
                    {
                        currentRow = currentRow - 1;
                    }

                    else
                    {
                        isPlayerOut = true;
                    }

                    if (!isBunny(field, currentRow, currentCol))
                    {
                        isBunnyHit = bunnyMultiplyer(rows, cols, field, isBunnyHit, currentRow, currentCol, isPlayerOut);
                    }

                    else if (isBunny(field, currentRow, currentCol))
                    {
                        isBunnyHit = true;
                        isBunnyHit = bunnyMultiplyer(rows, cols, field, isBunnyHit, currentRow, currentCol, isPlayerOut);
                    }
                }

                else if (currentDirection == 'D')
                {
                    if (currentRow + 1 < field.GetLength(0))
                    {
                        currentRow = currentRow + 1;
                    }

                    else
                    {
                        isPlayerOut = true;
                    }

                    if (!isBunny(field, currentRow, currentCol))
                    {
                        isBunnyHit = bunnyMultiplyer(rows, cols, field, isBunnyHit, currentRow, currentCol, isPlayerOut);
                    }

                    else if (isBunny(field, currentRow, currentCol))
                    {
                        isBunnyHit = true;
                        isBunnyHit = bunnyMultiplyer(rows, cols, field, isBunnyHit, currentRow, currentCol, isPlayerOut);
                    }
                }

                else if (currentDirection == 'L')
                {
                    if (currentCol - 1 >= 0)
                    {
                        currentCol = currentCol - 1;
                    }
                    else
                    {
                        isPlayerOut = true;
                    }

                    if (!isBunny(field, currentRow, currentCol))
                    {
                        isBunnyHit = bunnyMultiplyer(rows, cols, field, isBunnyHit, currentRow, currentCol, isPlayerOut);
                    }

                    else if (isBunny(field, currentRow, currentCol))
                    {
                        isBunnyHit = true;
                        isBunnyHit = bunnyMultiplyer(rows, cols, field, isBunnyHit, currentRow, currentCol, isPlayerOut);
                    }
                }

                else if (currentDirection == 'R')
                {
                    if (currentCol + 1 < field.GetLength(1))
                    {
                        currentCol = currentCol + 1;
                    }

                    else
                    {
                        isPlayerOut = true;
                    }

                    if (!isBunny(field, currentRow, currentCol))
                    {
                        isBunnyHit = bunnyMultiplyer(rows, cols, field, isBunnyHit, currentRow, currentCol, isPlayerOut);
                    }

                    else if (isBunny(field, currentRow, currentCol))
                    {
                        isBunnyHit = true;
                        isBunnyHit = bunnyMultiplyer(rows, cols, field, isBunnyHit, currentRow, currentCol, isPlayerOut);
                    }
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }

            if (isPlayerOut)
            {
                Console.WriteLine($"won: {currentRow} {currentCol}");
            }

            if (isBunnyHit)
            {
                Console.WriteLine($"dead: {currentRow} {currentCol}");
            }
        }


        private static bool bunnyMultiplyer(int rows, int cols, char[,] field, bool isBunnyHit, int currentRow, int currentCol, bool isPlayerOut)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (field[row, col] == 'B')
                    {
                        if (row - 1 >= 0 && row - 1 == currentRow && col == currentCol && !isPlayerOut)
                        {
                            isBunnyHit = true;
                            field[row - 1, col] = 'b';
                        }

                        else if (row - 1 >= 0 && field[row - 1, col] != 'B')
                        {
                            field[row - 1, col] = 'b';
                        }

                        if (row + 1 < field.GetLength(0) && row + 1 == currentRow && col == currentCol && !isPlayerOut)
                        {
                            isBunnyHit = true;
                            field[row + 1, col] = 'b';
                        }

                        else if (row + 1 < field.GetLength(0) && field[row + 1, col] != 'B')
                        {
                            field[row + 1, col] = 'b';
                        }

                        if (col - 1 >= 0 && row == currentRow && col - 1 == currentCol && !isPlayerOut)
                        {
                            isBunnyHit = true;
                            field[row, col - 1] = 'b';
                        }

                        else if (col - 1 >= 0 && field[row, col - 1] != 'B')
                        {
                            field[row, col - 1] = 'b';
                        }

                        if (col + 1 < field.GetLength(1) && row == currentRow && col + 1 == currentCol && !isPlayerOut)
                        {
                            isBunnyHit = true;
                            field[row, col + 1] = 'b';
                        }

                        else if (col + 1 < field.GetLength(1) && field[row, col + 1] != 'B')
                        {
                            field[row, col + 1] = 'b';
                        }
                    }
                }

            }
            for (int row2nd = 0; row2nd < rows; row2nd++)
            {
                for (int col2nd = 0; col2nd < cols; col2nd++)
                {
                    if (field[row2nd, col2nd] == 'b')
                    {
                        field[row2nd, col2nd] = 'B';
                    }
                }
            }

            return isBunnyHit;
        }

        private static bool isBunny(char[,] field, int currentRow, int currentCol)
        {
            return field[currentRow, currentCol] == 'B';
        }

    }
}