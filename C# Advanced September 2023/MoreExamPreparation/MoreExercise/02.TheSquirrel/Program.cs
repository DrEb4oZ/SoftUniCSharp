namespace _02.TheSquirrel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] field = new char[size, size];
            int squirrelRow = 0;
            int squirrelCol = 0;
            int totalHazelnutCount = 0;
            string[] directions = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            for (int row = 0; row < size; row++)
            {
                char[] currentRow = Console.ReadLine().ToArray();
                for (int col = 0; col < size; col++)
                {
                    field[row, col] = currentRow[col];

                    if (field[row,col] == 's')
                    {
                        squirrelRow = row;
                        squirrelCol = col;
                    }

                    if (field[row,col] == 'h')
                    {
                        totalHazelnutCount++;
                    }
                }
            }
            int hazelnutCollected = 0;
            bool isSquirlFailed = false;
            for (int i = 0; i < directions.Length; i++)
            {
                string direction = directions[i];

                if(direction == "up")
                {
                    if (squirrelRow - 1 < 0)
                    {
                        Console.WriteLine("The squirrel is out of the field.");
                        isSquirlFailed = true;
                        break;
                    }

                    if (field[squirrelRow - 1, squirrelCol] == 't')
                    {
                        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                        isSquirlFailed = true;
                        break;
                    }

                    if (field[squirrelRow - 1, squirrelCol] == 'h')
                    {
                        squirrelRow = squirrelRow - 1;
                        hazelnutCollected++;
                        totalHazelnutCount--;
                        field[squirrelRow, squirrelCol] = '*';
                        if (totalHazelnutCount == 0)
                        {
                            Console.WriteLine("Good job! You have collected all hazelnuts!");
                            break;
                        }
                        continue;
                    }

                    squirrelRow = squirrelRow - 1;
                }

                else if (direction == "down")
                {
                    if (squirrelRow + 1 >= size)
                    {
                        Console.WriteLine("The squirrel is out of the field.");
                        isSquirlFailed = true;
                        break;
                    }

                    if (field[squirrelRow + 1, squirrelCol] == 't')
                    {
                        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                        isSquirlFailed = true;
                        break;
                    }

                    if (field[squirrelRow + 1, squirrelCol] == 'h')
                    {
                        squirrelRow = squirrelRow + 1;
                        hazelnutCollected++;
                        totalHazelnutCount--;
                        field[squirrelRow, squirrelCol] = '*';
                        if (totalHazelnutCount == 0)
                        {
                            Console.WriteLine("Good job! You have collected all hazelnuts!");
                            break;
                        }
                        continue;
                    }

                    squirrelRow = squirrelRow + 1;
                }

                else if (direction == "left")
                {
                    if (squirrelCol - 1 < 0)
                    {
                        Console.WriteLine("The squirrel is out of the field.");
                        isSquirlFailed = true;
                        break;
                    }

                    if (field[squirrelRow,squirrelCol - 1] == 't')
                    {
                        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                        isSquirlFailed = true;
                        break;
                    }

                    if (field[squirrelRow, squirrelCol - 1] == 'h')
                    {
                        squirrelCol = squirrelCol - 1;
                        hazelnutCollected++;
                        totalHazelnutCount--;
                        field[squirrelRow, squirrelCol] = '*';
                        if (totalHazelnutCount == 0)
                        {
                            Console.WriteLine("Good job! You have collected all hazelnuts!");
                            break;
                        }
                        continue;
                    }

                    squirrelCol = squirrelCol - 1;
                }

                else if (direction == "right")
                {
                    if (squirrelCol + 1 >= size)
                    {
                        Console.WriteLine("The squirrel is out of the field.");
                        isSquirlFailed = true;
                        break;
                    }

                    if (field[squirrelRow, squirrelCol + 1] == 't')
                    {
                        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                        isSquirlFailed = true;
                        break;
                    }

                    if (field[squirrelRow, squirrelCol + 1] == 'h')
                    {
                        squirrelCol = squirrelCol + 1;
                        hazelnutCollected++;
                        totalHazelnutCount--;
                        field[squirrelRow, squirrelCol] = '*';
                        if (totalHazelnutCount == 0)
                        {
                            Console.WriteLine("Good job! You have collected all hazelnuts!");
                            break;
                        }
                        continue;
                    }

                    squirrelCol = squirrelCol + 1;
                }
            }

            if (totalHazelnutCount > 0 && !isSquirlFailed)
            {
                Console.WriteLine("There are more hazelnuts to collect.");
            }
            Console.WriteLine($"Hazelnuts collected: {hazelnutCollected}");

        }
    }
}