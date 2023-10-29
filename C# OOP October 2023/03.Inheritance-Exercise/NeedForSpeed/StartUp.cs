using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            RaceMotorcycle rMotorcycle = new RaceMotorcycle(10, 500);

            Console.WriteLine(rMotorcycle.Fuel);

            rMotorcycle.Drive(10);

            Console.WriteLine(rMotorcycle.Fuel);
        }
    }
}
