namespace _02.NavyBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] battleField = new char[size, size];
            int submarineRow = 0;
            int submarineCol = 0;
            for (int row = 0; row < size; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    battleField[row, col] = currentRow[col];
                    if (battleField[row, col] == 'S')
                    {
                        submarineRow = row;
                        submarineCol = col;
                        battleField[row, col] = '-';
                    }
                }
            }
            int mineHit = 0;
            int enemyShips = 3;
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "up")
                {
                    submarineRow--;
                    if (battleField[submarineRow, submarineCol] == '*')
                    {
                        mineHit++;
                        battleField[submarineRow, submarineCol] = '-';
                        if (mineHit == 3)
                        {
                            battleField[submarineRow, submarineCol] = 'S';
                            Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submarineRow}, {submarineCol}]!");
                            break;
                        }
                        continue;
                    }

                    if (battleField[submarineRow, submarineCol] == 'C')
                    {
                        enemyShips--;
                        battleField[submarineRow, submarineCol] = '-';
                        if (enemyShips == 0)
                        {
                            battleField[submarineRow, submarineCol] = 'S';
                            Console.WriteLine($"Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                            break;
                        }
                        continue;
                    }
                }

                else if (command == "down")
                {
                    submarineRow++;
                    if (battleField[submarineRow, submarineCol] == '*')
                    {
                        mineHit++;
                        battleField[submarineRow, submarineCol] = '-';
                        if (mineHit == 3)
                        {
                            battleField[submarineRow, submarineCol] = 'S';
                            Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submarineRow}, {submarineCol}]!");
                            break;
                        }
                        continue;
                    }

                    if (battleField[submarineRow, submarineCol] == 'C')
                    {
                        enemyShips--;
                        battleField[submarineRow, submarineCol] = '-';
                        if (enemyShips == 0)
                        {
                            battleField[submarineRow, submarineCol] = 'S';
                            Console.WriteLine($"Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                            break;
                        }
                        continue;
                    }
                }

                else if (command == "left")
                {
                    submarineCol--;
                    if (battleField[submarineRow, submarineCol] == '*')
                    {
                        mineHit++;
                        battleField[submarineRow, submarineCol] = '-';
                        if (mineHit == 3)
                        {
                            battleField[submarineRow, submarineCol] = 'S';
                            Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submarineRow}, {submarineCol}]!");
                            break;
                        }
                        continue;
                    }

                    if (battleField[submarineRow, submarineCol] == 'C')
                    {
                        enemyShips--;
                        battleField[submarineRow, submarineCol] = '-';
                        if (enemyShips == 0)
                        {
                            battleField[submarineRow, submarineCol] = 'S';
                            Console.WriteLine($"Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                            break;
                        }
                        continue;
                    }
                }

                else if (command == "right")
                {
                    submarineCol++;
                    if (battleField[submarineRow, submarineCol] == '*')
                    {
                        mineHit++;
                        battleField[submarineRow, submarineCol] = '-';
                        if (mineHit == 3)
                        {
                            battleField[submarineRow, submarineCol] = 'S';
                            Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submarineRow}, {submarineCol}]!");
                            break;
                        }
                        continue;
                    }

                    if (battleField[submarineRow, submarineCol] == 'C')
                    {
                        enemyShips--;
                        battleField[submarineRow, submarineCol] = '-';
                        if (enemyShips == 0)
                        {
                            battleField[submarineRow, submarineCol] = 'S';
                            Console.WriteLine($"Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                            break;
                        }
                        continue;
                    }
                }
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(battleField[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}