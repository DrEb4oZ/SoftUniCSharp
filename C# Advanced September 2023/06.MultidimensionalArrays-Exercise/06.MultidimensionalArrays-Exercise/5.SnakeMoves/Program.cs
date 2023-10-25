namespace _5.SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            string[,] snakeMovemnet = new string[rows, cols];
            string snake = Console.ReadLine();
            char[] snakeChars = snake.ToCharArray();
            int currentChar = 0;
            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (currentChar < snake.Length)
                        {
                            snakeMovemnet[row, col] = snakeChars[currentChar].ToString();
                            currentChar++;
                        }

                        else
                        {
                            currentChar = 0;
                            snakeMovemnet[row, col] = snakeChars[currentChar].ToString();
                            currentChar++;
                        }
                    }
                }

                else
                {
                    for (int col2 = cols - 1; col2 >= 0; col2--)
                    {
                        if (currentChar < snake.Length)
                        {
                            snakeMovemnet[row, col2] = snakeChars[currentChar].ToString();
                            currentChar++;
                        }

                        else
                        {
                            currentChar = 0;
                            snakeMovemnet[row, col2] = snakeChars[currentChar].ToString();
                            currentChar++;
                        }
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(snakeMovemnet[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}