using System;

namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingmachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int birthdaySum = 10;
            int totalIncome = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    totalIncome += birthdaySum - 1;
                    birthdaySum += 10;
                }
                else
                {
                    totalIncome += toyPrice;
                }
            }
            if (totalIncome >= washingmachinePrice)
            {
                Console.WriteLine($"Yes! {totalIncome - washingmachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingmachinePrice - totalIncome:f2}");
            }
        }
    }
}
