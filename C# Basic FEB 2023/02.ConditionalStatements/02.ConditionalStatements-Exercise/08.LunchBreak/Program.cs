using System;

namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sereilName = Console.ReadLine();
            int episodLenght = int.Parse(Console.ReadLine());
            int breakLenght = int.Parse(Console.ReadLine());
            double lunchTime = breakLenght * 1 / 8.0;
            double breakTime = breakLenght * 1 / 4.0;
            double timeLeftForSerial = breakLenght - lunchTime - breakTime;
            if (timeLeftForSerial >= episodLenght)
            {
                Console.WriteLine($"You have enough time to watch {sereilName} and left with {Math.Ceiling(timeLeftForSerial - episodLenght)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {sereilName}, you need {Math.Ceiling(episodLenght - timeLeftForSerial)} more minutes.");
            }
        }
    }
}
