using System;

namespace _02.SleepyTomCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int freeDaysCount = int.Parse(Console.ReadLine());
            int totalPlayTime = (365 - freeDaysCount) * 63 + freeDaysCount * 127;
            int freeTime = 30000 - totalPlayTime;
            int hour = freeTime / 60;
            int minutes = freeTime % 60;
            if (totalPlayTime <= 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hour} hours and {minutes} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Abs(hour)} hours and {Math.Abs(minutes)} minutes more for play");
            }
        }
    }
}
