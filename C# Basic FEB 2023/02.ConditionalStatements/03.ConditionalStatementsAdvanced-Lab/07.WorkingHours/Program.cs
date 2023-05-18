using System;

namespace _07.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourOfTheDay = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();
            if (dayOfWeek != "Sunday" && hourOfTheDay >= 10 && hourOfTheDay <= 18)
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
