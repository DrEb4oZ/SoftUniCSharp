using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int freeSpaceWidth = int.Parse(Console.ReadLine());
            int freeSpaceLenght = int.Parse(Console.ReadLine());
            int freeSpaceHeight = int.Parse(Console.ReadLine());
            string boxesCount = Console.ReadLine();
            int freeSpace = freeSpaceWidth * freeSpaceLenght * freeSpaceHeight;
            int totalBoxesCount = 0;

            while (freeSpace > 0 && boxesCount != "Done")
            {
                int currentBoxesCount = int.Parse(boxesCount);
                freeSpace -= currentBoxesCount;
                totalBoxesCount += currentBoxesCount;
                boxesCount = Console.ReadLine();
            }
            if (freeSpace >= 0)
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
            else
            {
                int neededCubicMetersSpace = totalBoxesCount - (freeSpaceWidth * freeSpaceLenght * freeSpaceHeight);
                Console.WriteLine($"No more free space! You need {neededCubicMetersSpace} Cubic meters more.");
            }
        }
    }
}
