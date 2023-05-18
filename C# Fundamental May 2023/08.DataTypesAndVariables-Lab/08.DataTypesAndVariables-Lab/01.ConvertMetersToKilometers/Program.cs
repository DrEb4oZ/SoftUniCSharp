namespace _01.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distanceMeter = int.Parse(Console.ReadLine());
            double distanceKm = (double)distanceMeter / 1000;

            Console.WriteLine($"{distanceKm:f2}");
        }
    }
}