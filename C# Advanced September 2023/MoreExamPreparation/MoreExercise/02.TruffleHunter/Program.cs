using System;
using System.Linq;

namespace _02.TruffleHunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] forest = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                char[] currentRow = Console.ReadLine()
                    .Split(" ")
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < size; col++)
                {
                    forest[row, col] = currentRow[col];
                }
            }
            int blackTruffleCount = 0;
            int summerTruffleCount = 0;
            int whiteTruffleCount = 0;
            int truffleEatenByBoarCount = 0;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Stop the hunt")
            {
                string[] commandTokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (commandTokens[0] == "Collect")
                {
                    int collectRow = int.Parse(commandTokens[1]);
                    int collectCol = int.Parse(commandTokens[2]);

                    if (forest[collectRow, collectCol] == 'B')
                    {
                        blackTruffleCount++;
                        forest[collectRow, collectCol] = '-';
                    }

                    else if (forest[collectRow, collectCol] == 'S')
                    {
                        summerTruffleCount++;
                        forest[collectRow, collectCol] = '-';
                    }

                    else if (forest[collectRow, collectCol] == 'W')
                    {
                        whiteTruffleCount++;
                        forest[collectRow, collectCol] = '-';
                    }

                }

                else if (commandTokens[0] == "Wild_Boar")
                {
                    int boarRow = int.Parse(commandTokens[1]);
                    int boarCol = int.Parse(commandTokens[2]);
                    string direction = commandTokens[3];

                    if (direction == "up")
                    {
                        for (int i = boarRow; i >= 0; i -= 2)
                        {
                            if (forest[i, boarCol] == 'B' || forest[i, boarCol] == 'S' || forest[i, boarCol] == 'W')
                            {
                                truffleEatenByBoarCount++;
                                forest[i, boarCol] = '-';
                            }
                        }
                    }

                    else if (direction == "down")
                    {
                        for (int i = boarRow; i < size; i += 2)
                        {
                            if (forest[i, boarCol] == 'B' || forest[i, boarCol] == 'S' || forest[i, boarCol] == 'W')
                            {
                                truffleEatenByBoarCount++;
                                forest[i, boarCol] = '-';
                            }
                        }
                    }

                    else if (direction == "left")
                    {
                        for (int i = boarCol; i >= 0; i -= 2)
                        {
                            if (forest[boarRow, i] == 'B' || forest[boarRow, i] == 'S' || forest[boarRow, i] == 'W')
                            {
                                truffleEatenByBoarCount++;
                                forest[boarRow, i] = '-';
                            }
                        }
                    }

                    else if (direction == "right")
                    {
                        for (int i = boarCol; i < size; i += 2)
                        {
                            if (forest[boarRow, i] == 'B' || forest[boarRow, i] == 'S' || forest[boarRow, i] == 'W')
                            {
                                truffleEatenByBoarCount++;
                                forest[boarRow, i] = '-';
                            }
                        }
                    }
                }

            }

            Console.WriteLine($"Peter manages to harvest {blackTruffleCount} black, {summerTruffleCount} summer, and {whiteTruffleCount} white truffles.");
            Console.WriteLine($"The wild boar has eaten {truffleEatenByBoarCount} truffles.");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write($"{forest[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}