namespace _02.FishingCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] fishingArea = new char[size, size];
            int shipRow = 0;
            int shipCol = 0;

            for (int row = 0; row < size; row++)
            {
                string currentRow = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    fishingArea[row, col] = currentRow[col];
                    if (fishingArea[row, col] == 'S')
                    {
                        shipRow = row;
                        shipCol = col;
                        fishingArea[row, col] = '-';
                    }
                }
            }
            double fishCollected = 0;
            bool shipHitWhirpool = false;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "collect the nets")
            {
                if (command == "up")
                {
                    if (shipRow - 1 < 0)
                    {
                        shipRow = size - 1;
                        if (fishingArea[shipRow, shipCol] == 'W')
                        {
                            fishCollected = 0;
                            shipHitWhirpool = true;
                            break;
                        }

                        if (fishingArea[shipRow, shipCol] == '-')
                        {
                            continue;
                        }

                        fishCollected += char.GetNumericValue(fishingArea[shipRow, shipCol]);
                        fishingArea[shipRow, shipCol] = '-';
                        continue;
                    }

                    shipRow = shipRow - 1;
                    if (fishingArea[shipRow, shipCol] == 'W')
                    {
                        fishCollected = 0;
                        shipHitWhirpool = true;
                        break;
                    }

                    if (fishingArea[shipRow, shipCol] == '-')
                    {
                        continue;
                    }

                    fishCollected += char.GetNumericValue(fishingArea[shipRow, shipCol]);
                    fishingArea[shipRow, shipCol] = '-';
                }

                else if (command == "down")
                {
                    if (shipRow + 1 >= size)
                    {
                        shipRow = 0;
                        if (fishingArea[shipRow, shipCol] == 'W')
                        {
                            fishCollected = 0;
                            shipHitWhirpool = true;
                            break;
                        }

                        if (fishingArea[shipRow, shipCol] == '-')
                        {
                            continue;
                        }

                        fishCollected += char.GetNumericValue(fishingArea[shipRow, shipCol]);
                        fishingArea[shipRow, shipCol] = '-';
                        continue;
                    }

                    shipRow = shipRow + 1;
                    if (fishingArea[shipRow, shipCol] == 'W')
                    {
                        fishCollected = 0;
                        shipHitWhirpool = true;
                        break;
                    }

                    if (fishingArea[shipRow, shipCol] == '-')
                    {
                        continue;
                    }

                    fishCollected += char.GetNumericValue(fishingArea[shipRow, shipCol]);
                    fishingArea[shipRow, shipCol] = '-';
                }

                else if (command == "left")
                {
                    if (shipCol - 1 < 0)
                    {
                        shipCol = size - 1;
                        if (fishingArea[shipRow, shipCol] == 'W')
                        {
                            fishCollected = 0;
                            shipHitWhirpool = true;
                            break;
                        }

                        if (fishingArea[shipRow, shipCol] == '-')
                        {
                            continue;
                        }

                        fishCollected += char.GetNumericValue(fishingArea[shipRow, shipCol]);
                        fishingArea[shipRow, shipCol] = '-';
                        continue;
                    }

                    shipCol = shipCol - 1;
                    if (fishingArea[shipRow, shipCol] == 'W')
                    {
                        fishCollected = 0;
                        shipHitWhirpool = true;
                        break;
                    }

                    if (fishingArea[shipRow, shipCol] == '-')
                    {
                        continue;
                    }

                    fishCollected += char.GetNumericValue(fishingArea[shipRow, shipCol]);
                    fishingArea[shipRow, shipCol] = '-';
                }

                else if (command == "right")
                {
                    if (shipCol + 1 >= size)
                    {
                        shipCol = 0;
                        if (fishingArea[shipRow, shipCol] == 'W')
                        {
                            fishCollected = 0;
                            shipHitWhirpool = true;
                            break;
                        }

                        if (fishingArea[shipRow, shipCol] == '-')
                        {
                            continue;
                        }

                        fishCollected += char.GetNumericValue(fishingArea[shipRow, shipCol]);
                        fishingArea[shipRow, shipCol] = '-';
                        continue;
                    }

                    shipCol = shipCol + 1;
                    if (fishingArea[shipRow, shipCol] == 'W')
                    {
                        fishCollected = 0;
                        shipHitWhirpool = true;
                        break;
                    }

                    if (fishingArea[shipRow, shipCol] == '-')
                    {
                        continue;
                    }

                    fishCollected += char.GetNumericValue(fishingArea[shipRow, shipCol]);
                    fishingArea[shipRow, shipCol] = '-';
                }
            }

            fishingArea[shipRow, shipCol] = 'S';
            if (shipHitWhirpool)
            {
                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{shipRow},{shipCol}]");
            }

            else if (fishCollected >= 20)
            {
                Console.WriteLine("Success! You managed to reach the quota!");

            }

            else
            {
                Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - fishCollected} tons of fish more.");
                //Console.WriteLine($"");
            }

            if (fishCollected > 0)
            {
                Console.WriteLine($"Amount of fish caught: {fishCollected} tons.");

            }

            if (!shipHitWhirpool)
            {
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        Console.Write(fishingArea[row, col]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}