﻿using System;
using System.Threading;

namespace _01.ReadText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while (text != "Stop")
            {
                Console.WriteLine(text);
                text = Console.ReadLine();
            }
        }
    }
}
