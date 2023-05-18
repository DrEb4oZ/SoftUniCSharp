using System;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rowCount = int.Parse(Console.ReadLine());
            int columnCount = int.Parse(Console.ReadLine());
            double price = 0;
            if (projectionType == "Premiere")
            {
                price = 12;
            }
            else if (projectionType == "Normal")
            {
                price = 7.50;
            }
            else if (projectionType == "Discount")
            {
                price = 5.00;
            }
            double income = rowCount * columnCount * price;
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
