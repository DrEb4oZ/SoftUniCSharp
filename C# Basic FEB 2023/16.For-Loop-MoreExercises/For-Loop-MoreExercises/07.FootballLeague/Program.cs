using System;

namespace _07.FootballLeague
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int fanCount = int.Parse(Console.ReadLine());
            bool fullCapacity = false;
            int sectorCountA = 0, sectorCountB = 0, sectorCountV = 0, sectorCountG = 0;

            for (int i = 0; i < fanCount || fullCapacity; i++)
            {
                string currentSector = Console.ReadLine();

                if (currentSector == "A")
                {
                    sectorCountA++;
                }
                else if (currentSector == "B")
                {
                    sectorCountB++;
                }
                else if (currentSector == "V")
                {
                    sectorCountV++;
                }
                else if (currentSector == "G")
                {
                    sectorCountG++;
                }
            }
            int totalFan = sectorCountA + sectorCountB + sectorCountV + sectorCountG;
            double sectorPercentA = (double)sectorCountA / totalFan * 100;
            double sectorPercentB = (double)sectorCountB / totalFan * 100;
            double sectorPercentV = (double)sectorCountV / totalFan * 100;
            double sectorPercentG = (double)sectorCountG / totalFan * 100;
            double totalFanPercentToCapacity = (double)totalFan / stadiumCapacity * 100;

            Console.WriteLine($"{sectorPercentA:f2}%");
            Console.WriteLine($"{sectorPercentB:f2}%");
            Console.WriteLine($"{sectorPercentV:f2}%");
            Console.WriteLine($"{sectorPercentG:f2}%");
            Console.WriteLine($"{totalFanPercentToCapacity:f2}%");
        }
    }
}
