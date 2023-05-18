using System;
using System.Diagnostics.CodeAnalysis;

namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearTax = int.Parse(Console.ReadLine());

            double shoes = yearTax * (1-0.40);
            double clothes = shoes * (1 - .20);
            double basketballBall = clothes * 0.25;
            double basketballAccessories = basketballBall * 0.20;

            double sum = yearTax + shoes + clothes + basketballBall + basketballAccessories;

            Console.WriteLine(sum);
        }
    }
}
