using System;

namespace _06.WeddingSeats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rowCountSectorA = int.Parse(Console.ReadLine());
            int seatCountOddRow = int.Parse(Console.ReadLine());
            int allSeatsCount = 0;

            for (int i = 'A'; i <= lastSector; i++)
            {
                for (int j = 1; j <= rowCountSectorA; j++)
                {
                    int currentSeatCount = 'a' + seatCountOddRow - 1;
                    if (j % 2 == 0)
                    {
                        currentSeatCount += 2;
                    }

                    for (int k = 'a'; k <= currentSeatCount; k++)
                    {
                        Console.WriteLine($"{(char)i}{j}{(char)k} ");
                        allSeatsCount++;
                    }
                }
                rowCountSectorA++;
            }
            Console.WriteLine(allSeatsCount);
        }
    }
}
