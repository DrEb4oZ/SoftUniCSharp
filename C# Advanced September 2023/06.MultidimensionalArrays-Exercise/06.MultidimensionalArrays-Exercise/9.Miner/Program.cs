using System.Data;

namespace _9.Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dimension = int.Parse(Console.ReadLine());
            string[] directions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            char[,] field = new char[dimension, dimension];
            int[] startLocation = new int[2];
            int coalCount = 0;  //is it possible there is no coal at the begining??
            for (int row = 0; row < dimension; row++)
            {
                char[] rowInput = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < dimension; col++)
                {
                    field[row, col] = rowInput[col];
                    if (field[row, col] == 's')
                    {
                        startLocation[0] = row;
                        startLocation[1] = col;
                    }

                    if (field[row, col] == 'c')
                    {
                        coalCount++;
                    }

                }
            }
            int currentRow = startLocation[0];
            int currentCol = startLocation[1];
            bool isExitHit = false;
            for (int i = 0; i < directions.Length && coalCount > 0 && !isExitHit; i++)
            {
                string currentDirecton = directions[i];
                if (currentDirecton == "up" && currentRow - 1 >= 0)
                {
                    currentRow = currentRow - 1;
                    if (isCoal(field, currentRow, currentCol))
                    {
                        coalCount--;
                        field[currentRow, currentCol] = '*';
                    }

                    else if (isExit(field, currentRow, currentCol))
                    {
                        isExitHit = true;
                    }
                }

                else if (currentDirecton == "down" && currentRow + 1 < field.GetLength(0))
                {
                    currentRow = currentRow + 1;
                    if (isCoal(field, currentRow, currentCol))
                    {
                        coalCount--;
                        field[currentRow, currentCol] = '*';
                    }

                    else if (isExit(field, currentRow, currentCol))
                    {
                        isExitHit = true;
                    }
                }

                else if (currentDirecton == "left" && currentCol - 1 >= 0)
                {
                    currentCol = currentCol - 1;
                    if (isCoal(field, currentRow, currentCol))
                    {
                        coalCount--;
                        field[currentRow, currentCol] = '*';
                    }

                    else if (isExit(field, currentRow, currentCol))
                    {
                        isExitHit = true;
                    }
                }

                else if (currentDirecton == "right" && currentCol + 1 < field.GetLength(1))
                {
                    currentCol = currentCol + 1;
                    if (isCoal(field, currentRow, currentCol))
                    {
                        coalCount--;
                        field[currentRow, currentCol] = '*';
                    }

                    else if (isExit(field, currentRow, currentCol))
                    {
                        isExitHit = true;
                    }
                }
            }

            if (coalCount == 0)
            {
                Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
            }

            else if (isExitHit)
            {
                Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
            }

            else
            {
                Console.WriteLine($"{coalCount} coals left. ({currentRow}, {currentCol})");
            }
        }

        private static bool isExit(char[,] field, int currentRow, int currentCol)
        {
            return field[currentRow, currentCol] == 'e';
        }

        private static bool isCoal(char[,] field, int currentRow, int currentCol)
        {
            return field[currentRow, currentCol] == 'c';
        }
    }
}