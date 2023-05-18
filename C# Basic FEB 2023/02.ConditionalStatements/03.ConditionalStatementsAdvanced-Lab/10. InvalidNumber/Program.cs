using System;
using System.Reflection;

namespace _10._InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            //if (number !=0 && number < 100 || number > 200)
            //{
            //    Console.WriteLine("invalid");
            //}
            bool validNumber = (number >= 100 && number <= 200 || number == 0);
            if (!validNumber)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
