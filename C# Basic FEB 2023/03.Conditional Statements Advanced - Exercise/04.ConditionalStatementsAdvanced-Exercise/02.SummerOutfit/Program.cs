using System;

namespace _02.SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degree = int.Parse(Console.ReadLine());
            string partOfTheDay = Console.ReadLine();
            string outfit = "";
            string shoes = "";
            if (partOfTheDay == "Morning")
            {
                if (degree >=10 && degree <=18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degree > 18 && degree <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degree >= 25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (partOfTheDay == "Afternoon")
            {
                if (degree >= 10 && degree <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degree > 18 && degree <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (degree >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else if (partOfTheDay == "Evening")
            {
                if (degree >= 10 && degree <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degree > 18 && degree <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degree >= 25)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
        }
    }
}
