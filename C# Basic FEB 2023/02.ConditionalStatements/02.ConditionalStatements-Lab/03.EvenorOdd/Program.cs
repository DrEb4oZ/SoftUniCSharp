﻿using System;

namespace _03.EvenorOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 != 0)
            {
                Console.WriteLine("odd");
            }
            else
            {
                Console.WriteLine("even");
            } 
                
        }
    }
}
