using System;
namespace _07._School_Camp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int studentCount = int.Parse(Console.ReadLine());
            int nightsStay = int.Parse(Console.ReadLine());

            string sport = string.Empty;
            double totalPrice = 0; //f2
            double pricePerPerson = 0;

            //Logic
            if (season == "Winter" && (groupType == "boys" || groupType == "girls"))
                pricePerPerson = 9.60;
            else if (season == "Spring" && (groupType == "boys" || groupType == "girls"))
                pricePerPerson = 7.20;
            else if (season == "Summer" && (groupType == "boys" || groupType == "girls"))
                pricePerPerson = 15.00;
            else if (season == "Winter" && groupType == "mixed")
                pricePerPerson = 10.00;
            else if (season == "Spring" && groupType == "mixed")
                pricePerPerson = 9.50;
            else if (season == "Summer" && groupType == "mixed")
                pricePerPerson = 20.00;

            if (season == "Winter" && groupType == "girls")
                sport = "Gymnastics";
            else if (season == "Spring" && groupType == "girls")
                sport = "Athletics";
            else if (season == "Summer" && groupType == "girls")
                sport = "Volleyball";
            else if (season == "Winter" && groupType == "boys")
                sport = "Judo";
            else if (season == "Spring" && groupType == "boys")
                sport = "Tennis";
            else if (season == "Summer" && groupType == "boys")
                sport = "Football";
            else if (season == "Winter" && groupType == "mixed")
                sport = "Ski";
            else if (season == "Spring" && groupType == "mixed")
                sport = "Cycling";
            else if (season == "Summer" && groupType == "mixed")
                sport = "Swimming";

            totalPrice = pricePerPerson * nightsStay * studentCount;

            if (studentCount >= 10 && studentCount < 20)
                totalPrice *= 0.95;
            else if (studentCount < 50 && studentCount >= 20)
                totalPrice *= 0.85;
            else if (studentCount >= 50)
                totalPrice *= 0.50;

            //Output
            Console.WriteLine($"{sport} {totalPrice:f2} lv.");
        }
    }
}