namespace _02.MouseInTheKitchen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] cupboard = new char[rows, cols];
            int mouseRow = 0;
            int mouseCol = 0;
            int cheesCount = 0;
            for (int row = 0; row < rows; row++)
            {
                char[] currentRow = Console.ReadLine()
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    cupboard[row, col] = currentRow[col];

                    if (cupboard[row, col] == 'M')
                    {
                        mouseRow = row;
                        mouseCol = col;
                        cupboard[row, col] = '*';
                    }

                    if (cupboard[row, col] == 'C')
                    {
                        cheesCount++;
                    }
                }
            }
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "danger")
            {
                if (command == "up")
                {
                    if (mouseRow - 1 < 0)
                    {
                        Console.WriteLine("No more cheese for tonight!");
                        break;
                    }

                    if (cupboard[mouseRow - 1, mouseCol] == '@')
                    {
                        continue;
                    }

                    mouseRow = mouseRow - 1;

                    if (cupboard[mouseRow, mouseCol] == 'C')
                    {
                        cheesCount--;
                        cupboard[mouseRow, mouseCol] = '*';
                        if (cheesCount == 0)
                        {
                            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                            break;
                        }
                    }

                    if (cupboard[mouseRow, mouseCol] == 'T')
                    {
                        Console.WriteLine("Mouse is trapped!");
                        break;
                    }
                }

                else if (command == "down")
                {
                    if (mouseRow + 1 >= rows)
                    {
                        Console.WriteLine("No more cheese for tonight!");
                        break;
                    }

                    if (cupboard[mouseRow + 1, mouseCol] == '@')
                    {
                        continue;
                    }

                    mouseRow = mouseRow + 1;

                    if (cupboard[mouseRow, mouseCol] == 'C')
                    {
                        cheesCount--;
                        cupboard[mouseRow, mouseCol] = '*';
                        if (cheesCount == 0)
                        {
                            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                            break;
                        }
                    }

                    if (cupboard[mouseRow, mouseCol] == 'T')
                    {
                        Console.WriteLine("Mouse is trapped!");
                        break;
                    }
                }

                else if (command == "left")
                {
                    if (mouseCol - 1 < 0)
                    {
                        Console.WriteLine("No more cheese for tonight!");
                        break;
                    }

                    if (cupboard[mouseRow, mouseCol - 1] == '@')
                    {
                        continue;
                    }

                    mouseCol = mouseCol - 1;

                    if (cupboard[mouseRow, mouseCol] == 'C')
                    {
                        cheesCount--;
                        cupboard[mouseRow, mouseCol] = '*';
                        if (cheesCount == 0)
                        {
                            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                            break;
                        }
                    }

                    if (cupboard[mouseRow, mouseCol] == 'T')
                    {
                        Console.WriteLine("Mouse is trapped!");
                        break;
                    }
                }

                else if (command == "right")
                {
                    if (mouseCol + 1 >= cols)
                    {
                        Console.WriteLine("No more cheese for tonight!");
                        break;
                    }

                    if (cupboard[mouseRow, mouseCol + 1] == '@')
                    {
                        continue;
                    }

                    mouseCol = mouseCol + 1;

                    if (cupboard[mouseRow, mouseCol] == 'C')
                    {
                        cheesCount--;
                        cupboard[mouseRow, mouseCol] = '*';
                        if (cheesCount == 0)
                        {
                            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                            break;
                        }
                    }

                    if (cupboard[mouseRow, mouseCol] == 'T')
                    {
                        Console.WriteLine("Mouse is trapped!");
                        break;
                    }
                }
            }
            cupboard[mouseRow, mouseCol] = 'M';

            if (command == "danger")
            {
                Console.WriteLine("Mouse will come back later!");
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(cupboard[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}