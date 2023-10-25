using System;

namespace _02.Help_A_Mole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] playground = new char[size, size];
            int moleRow = 0;
            int moleCol = 0;
            int symbolSCount = 1;
            int firstSRow = 0;
            int firstSCol = 0;
            int secondSRow = 0;
            int secondSCol = 0;
            for (int row = 0; row < size; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    playground[row, col] = currentRow[col];

                    if (playground[row, col] == 'M')
                    {
                        moleRow = row;
                        moleCol = col;
                        playground[row, col] = '-';
                    }

                    if (playground[row, col] == 'S')
                    {
                        if (symbolSCount == 1)
                        {
                            firstSRow = row;
                            firstSCol = col;
                            symbolSCount++;
                        }

                        else
                        {
                            secondSRow = row;
                            secondSCol = col;
                        }
                    }

                }
            }
            double molePointsCount = 0;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "up")
                {
                    if (moleRow - 1 < 0)
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                        continue;
                    }

                    moleRow = moleRow - 1;

                    if (playground[moleRow, moleCol] == '-')
                    {
                        continue;
                    }

                    else if (playground[moleRow, moleCol] == 'S')
                    {
                        if (moleRow == firstSRow && moleCol == firstSCol)
                        {
                            playground[moleRow, moleCol] = '-';
                            moleRow = secondSRow;
                            moleCol = secondSCol;
                            playground[moleRow, moleCol] = '-';
                            molePointsCount -= 3;
                        }

                        else
                        {
                            playground[moleRow, moleCol] = '-';
                            moleRow = firstSRow;
                            moleCol = firstSCol;
                            playground[moleRow, moleCol] = '-';
                            molePointsCount -= 3;
                        }

                        continue;
                    }

                    molePointsCount += char.GetNumericValue(playground[moleRow, moleCol]);
                    playground[moleRow, moleCol] = '-';
                    if (molePointsCount >= 25)
                    {
                        break;
                    }
                }

                else if (command == "down")
                {
                    if (moleRow + 1 >= size)
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                        continue;
                    }

                    moleRow = moleRow + 1;

                    if (playground[moleRow, moleCol] == '-')
                    {
                        continue;
                    }

                    else if (playground[moleRow, moleCol] == 'S')
                    {
                        if (moleRow == firstSRow && moleCol == firstSCol)
                        {
                            playground[moleRow, moleCol] = '-';
                            moleRow = secondSRow;
                            moleCol = secondSCol;
                            playground[moleRow, moleCol] = '-';
                            molePointsCount -= 3;
                        }

                        else
                        {
                            playground[moleRow, moleCol] = '-';
                            moleRow = firstSRow;
                            moleCol = firstSCol;
                            playground[moleRow, moleCol] = '-';
                            molePointsCount -= 3;
                        }

                        continue;
                    }

                    molePointsCount += char.GetNumericValue(playground[moleRow, moleCol]);
                    playground[moleRow, moleCol] = '-';
                    if (molePointsCount >= 25)
                    {
                        break;
                    }
                }

                else if (command == "left")
                {
                    if (moleCol - 1 < 0)
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                        continue;
                    }

                    moleCol = moleCol - 1;

                    if (playground[moleRow, moleCol] == '-')
                    {
                        continue;
                    }

                    else if (playground[moleRow, moleCol] == 'S')
                    {
                        if (moleRow == firstSRow && moleCol == firstSCol)
                        {
                            playground[moleRow, moleCol] = '-';
                            moleRow = secondSRow;
                            moleCol = secondSCol;
                            playground[moleRow, moleCol] = '-';
                            molePointsCount -= 3;
                        }

                        else
                        {
                            playground[moleRow, moleCol] = '-';
                            moleRow = firstSRow;
                            moleCol = firstSCol;
                            playground[moleRow, moleCol] = '-';
                            molePointsCount -= 3;
                        }

                        continue;
                    }

                    molePointsCount += char.GetNumericValue(playground[moleRow, moleCol]);
                    playground[moleRow, moleCol] = '-';
                    if (molePointsCount >= 25)
                    {
                        break;
                    }
                }

                else if (command == "right")
                {
                    if (moleCol + 1 >= size)
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                        continue;
                    }

                    moleCol = moleCol + 1;

                    if (playground[moleRow, moleCol] == '-')
                    {
                        continue;
                    }

                    else if (playground[moleRow, moleCol] == 'S')
                    {
                        if (moleRow == firstSRow && moleCol == firstSCol)
                        {
                            playground[moleRow, moleCol] = '-';
                            moleRow = secondSRow;
                            moleCol = secondSCol;
                            playground[moleRow, moleCol] = '-';
                            molePointsCount -= 3;
                        }

                        else
                        {
                            playground[moleRow, moleCol] = '-';
                            moleRow = firstSRow;
                            moleCol = firstSCol;
                            playground[moleRow, moleCol] = '-';
                            molePointsCount -= 3;
                        }

                        continue;
                    }

                    molePointsCount += char.GetNumericValue(playground[moleRow, moleCol]);
                    playground[moleRow, moleCol] = '-';
                    if (molePointsCount >= 25)
                    {
                        break;
                    }
                }
            }

            playground[moleRow, moleCol] = 'M';
            if (molePointsCount >= 25)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {molePointsCount} points.");
            }

            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {molePointsCount} points.");
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(playground[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}