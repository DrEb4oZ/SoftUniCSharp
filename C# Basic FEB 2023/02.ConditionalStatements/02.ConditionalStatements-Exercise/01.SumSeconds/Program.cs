using System;

namespace _01.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int competitor1Time = int.Parse(Console.ReadLine());
            int competitor2Time = int.Parse(Console.ReadLine());
            int competitor3Time = int.Parse(Console.ReadLine());
            int sumTime = competitor1Time + competitor2Time + competitor3Time;
            int minutes = sumTime / 60;
            int seconds = sumTime % 60;
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }    
        }
    }
}
