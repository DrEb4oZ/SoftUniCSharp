﻿namespace _01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());

            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if(dayOfWeek >= 1 && dayOfWeek <= 7) Console.WriteLine(daysOfWeek[dayOfWeek-1]);
            else Console.WriteLine("Invalid day!");
        }
    }
}