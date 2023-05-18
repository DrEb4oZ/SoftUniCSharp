using System;

namespace _01.PipesInPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poolCapacityInLiter = int.Parse(Console.ReadLine());
            int pipe1LitersPerHour = int.Parse(Console.ReadLine());
            int pipe2LitersPerHour = int.Parse(Console.ReadLine());
            double hoursWorkerOut = double.Parse(Console.ReadLine());
            double pipe1TotalLiters = pipe1LitersPerHour * hoursWorkerOut;
            double pipe2TotalLiters = pipe2LitersPerHour * hoursWorkerOut;
            double totalLiters =  pipe1TotalLiters + pipe2TotalLiters;
            if (totalLiters <= poolCapacityInLiter)
            {
                double filledCapacityInPercent = totalLiters / poolCapacityInLiter * 100.0;
                double pipe1Percent = pipe1TotalLiters / totalLiters * 100.00;
                Console.WriteLine($"The pool is {filledCapacityInPercent:f2}% full. Pipe 1: {pipe1Percent:f2}%. Pipe 2: {100 - pipe1Percent:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {hoursWorkerOut} hours the pool overflows with {totalLiters - poolCapacityInLiter:f2} liters.");
            }
        }
    }
}
