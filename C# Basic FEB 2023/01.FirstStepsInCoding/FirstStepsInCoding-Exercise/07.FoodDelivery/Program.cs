using System;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegetarianMenu = int.Parse(Console.ReadLine());

            double orderSum = (chickenMenu * 10.35 + fishMenu * 12.4 + vegetarianMenu * 8.15) * 1.2 + 2.50;

            Console.WriteLine(orderSum);
        }
    }
}
