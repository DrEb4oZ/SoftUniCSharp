﻿using System;

namespace _02.NumbersNTo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i > 0; i-=1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
