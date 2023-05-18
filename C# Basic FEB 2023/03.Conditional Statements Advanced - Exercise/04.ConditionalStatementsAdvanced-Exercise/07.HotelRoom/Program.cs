using System;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int overnightStayCount = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceApartment = 0;
            double discountStudio = 0;
            double discountApartment = 0;
            if (month == "May" || month == "October")
            {
                priceStudio = 50;
                priceApartment = 65;
                if (overnightStayCount < 13 && overnightStayCount > 7)
                {
                    discountStudio = 0.05;
                }
                else if (overnightStayCount > 14)
                {
                    discountStudio = 0.3;
                    discountApartment = 0.10;
                }
            }
            else if (month == "June" || month == "September")
            {
                priceStudio = 75.2;
                priceApartment = 68.7;
                if (overnightStayCount > 14)
                {
                    discountStudio = 0.2;
                    discountApartment = 0.10;
                }
            }
            else if (month == "July" || month == "August")
            {
                priceStudio = 76;
                priceApartment = 77;
                if (overnightStayCount > 14)
                {
                    discountApartment = 0.1;
                }
            }
            double finalPriceStudio = (priceStudio - discountStudio * priceStudio) * overnightStayCount;
            double finalPriceApartment = (priceApartment - discountApartment * priceApartment) * overnightStayCount;
            Console.WriteLine($"Apartment: {finalPriceApartment:f2} lv.");
            Console.WriteLine($"Studio: {finalPriceStudio:f2} lv.");
        }
    }
}
