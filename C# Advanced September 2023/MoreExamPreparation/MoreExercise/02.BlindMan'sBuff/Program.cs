/*
5 8
---O-P-O
-P-OO---
------O-
-PB-O--O
---O----
up
up
left
Finish
 */


namespace _02.BlindMan_sBuff
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
            char[,] playground = new char[rows, cols];
            int playerRow = 0;
            int playerCol = 0;
            int playersCatchedCount = 0;
            int movesMadeCount = 0;
            for (int row = 0; row < rows; row++)
            {
                char[] currentRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    playground[row, col] = currentRow[col];

                    if (playground[row, col] == 'B')
                    {
                        playerRow = row;
                        playerCol = col;  // chech if you will change 'B' to something else
                    }
                }
            }
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Finish")
            {
                if (command == "up")
                {
                    if (playerRow - 1 < 0 || playground[playerRow -1, playerCol] == 'O')
                    {
                        continue;
                    }

                    playerRow = playerRow - 1;
                    movesMadeCount++;
                    if (playground[playerRow,playerCol] == 'P')
                    {
                        playersCatchedCount++;
                        playground[playerRow, playerCol] = '-';
                        if (playersCatchedCount == 3)
                        {
                            break;
                        }
                    }
                }

                else if (command == "down")
                {
                    if (playerRow + 1 >= rows || playground[playerRow + 1, playerCol] == 'O')
                    {
                        continue;
                    }

                    playerRow = playerRow + 1;
                    movesMadeCount++;
                    if (playground[playerRow, playerCol] == 'P')
                    {
                        playersCatchedCount++;
                        playground[playerRow, playerCol] = '-';
                        if (playersCatchedCount == 3)
                        {
                            break;
                        }
                    }
                }

                else if (command == "left")
                {
                    if (playerCol - 1 < 0 || playground[playerRow, playerCol - 1] == 'O')
                    {
                        continue;
                    }

                    playerCol = playerCol - 1;
                    movesMadeCount++;
                    if (playground[playerRow, playerCol] == 'P')
                    {
                        playersCatchedCount++;
                        playground[playerRow, playerCol] = '-';
                        if (playersCatchedCount == 3)
                        {
                            break;
                        }
                    }
                }

                else if (command == "right")
                {
                    if (playerCol + 1 >= cols || playground[playerRow, playerCol + 1] == 'O')
                    {
                        continue;
                    }

                    playerCol = playerCol + 1;
                    movesMadeCount++;
                    if (playground[playerRow, playerCol] == 'P')
                    {
                        playersCatchedCount++;
                        playground[playerRow, playerCol] = '-';
                        if (playersCatchedCount == 3)
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("Game over!");
            Console.WriteLine($"Touched opponents: {playersCatchedCount} Moves made: {movesMadeCount}");
        }
    }
}