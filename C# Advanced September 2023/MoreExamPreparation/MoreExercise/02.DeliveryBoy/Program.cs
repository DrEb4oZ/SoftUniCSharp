namespace _02.DeliveryBoy
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
            char[,] neighborhood = new char[rows, cols];
            int pizzaBoyRow = 0;
            int startPositionRow = 0;
            int pizzaBoyCol = 0;
            int startPositionCol = 0;
            for (int row = 0; row < rows; row++)
            {
                char[] currentRow = Console.ReadLine().ToArray();
                for (int col = 0; col < cols; col++)
                {
                    neighborhood[row, col] = currentRow[col];

                    if (neighborhood[row, col] == 'B')
                    {
                        pizzaBoyRow = row;
                        pizzaBoyCol = col;
                        startPositionRow = row;
                        startPositionCol = col;
                        
                    }

                }
            }
            
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "up")
                {
                    if (pizzaBoyRow - 1 < 0)
                    {
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        neighborhood[startPositionRow, startPositionCol] = ' ';
                        break;
                    }

                    if (neighborhood[pizzaBoyRow - 1, pizzaBoyCol] == '*')
                    {
                        continue;
                    }

                    pizzaBoyRow = pizzaBoyRow - 1;
                    if (neighborhood[pizzaBoyRow, pizzaBoyCol] == 'P')
                    {
                        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
                        neighborhood[pizzaBoyRow, pizzaBoyCol] = 'R';
                        continue;
                    }

                    if (neighborhood[pizzaBoyRow, pizzaBoyCol] == 'A')
                    {
                        Console.WriteLine("Pizza is delivered on time! Next order...");
                        neighborhood[startPositionRow, startPositionCol] = 'B';
                        neighborhood[pizzaBoyRow, pizzaBoyCol] = 'P';
                        break;
                    }
                    neighborhood[pizzaBoyRow, pizzaBoyCol] = '.';
                }

                else if (command == "down")
                {
                    if (pizzaBoyRow + 1 >= rows)
                    {
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        neighborhood[startPositionRow, startPositionCol] = ' ';
                        break;
                    }

                    if (neighborhood[pizzaBoyRow + 1, pizzaBoyCol] == '*')
                    {
                        continue;
                    }

                    pizzaBoyRow = pizzaBoyRow + 1;
                    if (neighborhood[pizzaBoyRow, pizzaBoyCol] == 'P')
                    {
                        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
                        neighborhood[pizzaBoyRow, pizzaBoyCol] = 'R';
                        continue;
                    }

                    if (neighborhood[pizzaBoyRow, pizzaBoyCol] == 'A')
                    {
                        Console.WriteLine("Pizza is delivered on time! Next order...");
                        neighborhood[startPositionRow, startPositionCol] = 'B';
                        neighborhood[pizzaBoyRow, pizzaBoyCol] = 'P';
                        break;
                    }
                    neighborhood[pizzaBoyRow, pizzaBoyCol] = '.';
                }

                else if (command == "left")
                {
                    if (pizzaBoyCol - 1 < 0)
                    {
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        neighborhood[startPositionRow, startPositionCol] = ' ';
                        break;
                    }

                    if (neighborhood[pizzaBoyRow, pizzaBoyCol - 1] == '*')
                    {
                        continue;
                    }

                    pizzaBoyCol = pizzaBoyCol - 1;
                    if (neighborhood[pizzaBoyRow, pizzaBoyCol] == 'P')
                    {
                        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
                        neighborhood[pizzaBoyRow, pizzaBoyCol] = 'R';
                        continue;
                    }

                    if (neighborhood[pizzaBoyRow, pizzaBoyCol] == 'A')
                    {
                        Console.WriteLine("Pizza is delivered on time! Next order...");
                        neighborhood[startPositionRow, startPositionCol] = 'B';
                        neighborhood[pizzaBoyRow, pizzaBoyCol] = 'P';
                        break;
                    }
                    neighborhood[pizzaBoyRow, pizzaBoyCol] = '.';
                }

                else if (command == "right")
                {
                    if (pizzaBoyCol + 1 >= cols)
                    {
                        Console.WriteLine("The delivery is late. Order is canceled.");
                        neighborhood[startPositionRow, startPositionCol] = ' ';
                        break;
                    }

                    if (neighborhood[pizzaBoyRow, pizzaBoyCol + 1] == '*')
                    {
                        continue;
                    }

                    pizzaBoyCol = pizzaBoyCol + 1;
                    if (neighborhood[pizzaBoyRow, pizzaBoyCol] == 'P')
                    {
                        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
                        neighborhood[pizzaBoyRow, pizzaBoyCol] = 'R';
                        continue;
                    }

                    if (neighborhood[pizzaBoyRow, pizzaBoyCol] == 'A')
                    {
                        Console.WriteLine("Pizza is delivered on time! Next order...");
                        neighborhood[startPositionRow, startPositionCol] = 'B';
                        neighborhood[pizzaBoyRow, pizzaBoyCol] = 'P';
                        break;
                    }
                    neighborhood[pizzaBoyRow, pizzaBoyCol] = '.';
                }
            }



            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(neighborhood[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}