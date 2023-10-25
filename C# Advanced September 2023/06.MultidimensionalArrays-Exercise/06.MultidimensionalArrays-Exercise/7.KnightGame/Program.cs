namespace _7.KnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] chessBoard = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                string rowInput = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    chessBoard[row, col] = rowInput[col];
                }
            }

            int mostHits = int.MinValue;
            int mostHitsRow = 0;
            int mostHitsCol = 0;
            bool noHits = false;
            int removedPices = 0;
            while (!noHits)
            {
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        int hitsCount = 0;
                        if (chessBoard[row, col] == 'K')
                        {
                            if (isValidIndexes(size, row - 2, col - 1))
                            {
                                if (chessBoard[row - 2, col - 1] == 'K')
                                {
                                    hitsCount++;
                                }
                            }

                            if (isValidIndexes(size, row - 1, col - 2))
                            {
                                if (chessBoard[row - 1, col - 2] == 'K')
                                {
                                    hitsCount++;
                                }
                            }

                            if (isValidIndexes(size, row + 1, col - 2))
                            {
                                if (chessBoard[row + 1, col - 2] == 'K')
                                {
                                    hitsCount++;
                                }
                            }

                            if (isValidIndexes(size, row + 2, col - 1))
                            {
                                if (chessBoard[row + 2, col - 1] == 'K')
                                {
                                    hitsCount++;
                                }
                            }

                            if (isValidIndexes(size, row - 2, col + 1))
                            {
                                if (chessBoard[row - 2, col + 1] == 'K')
                                {
                                    hitsCount++;
                                }
                            }

                            if (isValidIndexes(size, row - 1, col + 2))
                            {
                                if (chessBoard[row - 1, col + 2] == 'K')
                                {
                                    hitsCount++;
                                }
                            }

                            if (isValidIndexes(size, row + 1, col + 2))
                            {
                                if (chessBoard[row + 1, col + 2] == 'K')
                                {
                                    hitsCount++;
                                }
                            }

                            if (isValidIndexes(size, row + 2, col + 1))
                            {
                                if (chessBoard[row + 2, col + 1] == 'K')
                                {
                                    hitsCount++;
                                }
                            }
                            if (hitsCount > mostHits)
                            {
                                mostHits = hitsCount;
                                mostHitsRow = row;
                                mostHitsCol = col;
                            }
                        }

                    }
                }

                if (mostHits > 0)
                {
                    chessBoard[mostHitsRow, mostHitsCol] = '0';
                    removedPices++;
                    mostHits = 0;
                }

                else
                {
                    noHits = true;
                }
            }

            Console.WriteLine(removedPices);
        }

        private static bool isValidIndexes(int size, int row, int col)
        {
            return row >= 0 && row < size && col >= 0 && col < size;
        }
    }
}