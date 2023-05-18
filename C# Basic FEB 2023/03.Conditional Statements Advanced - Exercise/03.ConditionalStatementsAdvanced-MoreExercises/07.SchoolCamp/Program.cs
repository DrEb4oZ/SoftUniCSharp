using System;

namespace _07.SchoolCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int studenCount = int.Parse(Console.ReadLine());
            int nightSpentCount = int.Parse(Console.ReadLine());
            double price = 0;
            string sportType = string.Empty;
            if (season == "Winter")
            {
                if (groupType == "boys" || groupType == "girls")
                {
                    price = 9.60;
                    if (groupType == "girls")
                    {
                        sportType = "Gymnastics";
                    }
                    else if (groupType == "boys")
                    {
                        sportType = "Judo";
                    }
                }
                else if (groupType == "mixed")
                {
                    price = 10.00;
                    sportType = "Ski";
                }
            }
            else if (season == "Spring")
            {
                if (groupType == "boys" || groupType == "girls")
                {
                    price = 7.20;
                    if (groupType == "girls")
                    {
                        sportType = "Athletics";
                    }
                    else if (groupType == "boys")
                    {
                        sportType = "Tennis";
                    }
                }
                else if (groupType == "mixed")
                {
                    price = 9.50;
                    sportType = "Cycling";
                }
            }
            else if (season == "Summer")
            {
                if (groupType == "boys" || groupType == "girls")
                {
                    price = 15.00;
                    if (groupType == "girls")
                    {
                        sportType = "Volleyball";
                    }
                    else if (groupType == "boys")
                    {
                        sportType = "Football";
                    }
                }
                else if (groupType == "mixed")
                {
                    price = 20.00;
                    sportType = "Swimming";
                }
            }
            if (studenCount >= 10 && studenCount < 20)
            {
                price *= 0.95;
            }
            else if (studenCount >= 20 && studenCount < 50)
            {
                price *= 0.85;
            }
            else if (studenCount >= 50)
            {
                price *= 0.50;
            }
            double finalPrice = price * studenCount * nightSpentCount;
            Console.WriteLine($"{sportType} {finalPrice:f2} lv.");
        }
    }
}
