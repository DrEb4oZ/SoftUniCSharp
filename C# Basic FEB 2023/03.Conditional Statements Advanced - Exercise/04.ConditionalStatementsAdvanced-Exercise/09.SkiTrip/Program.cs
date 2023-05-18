using System;

namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rate = Console.ReadLine();
            int nights = days - 1;
            double price = 0;
            if (roomType == "room for one person")
            {
                price = 18;
            }
            else if (roomType == "apartment")
            {
                if (days < 10)
                {
                    price = 25 * 0.7;
                }
                else if (days <= 15)
                {
                    price = 25 * 0.65;
                }
                else if (days > 15)
                {
                    price = 25 * 0.5;
                }
            }
            else if (roomType == "president apartment")
            {
                if (days < 10)
                {
                    price = 35 * 0.9;
                }
                else if (days <= 15)
                {
                    price = 35 * 0.85;
                }
                else if (days > 15)
                {
                    price = 35 * 0.8;
                }
            }
            if (rate == "positive")
            {
                price = price * 1.25;
            }
            else if (rate == "negative")
            {
                price = price * 0.90;
            }
            double finalPrice = price * nights;
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
