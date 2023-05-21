namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pouringCount = int.Parse(Console.ReadLine());
            int tankCapacity = 255;
            int littersOfWaterSum = 0;

            for (int i = 0; i < pouringCount; i++)
            {
                int littersOfWater = int.Parse(Console.ReadLine());
                if (tankCapacity < littersOfWater)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    tankCapacity -= littersOfWater;
                    littersOfWaterSum += littersOfWater;
                }
            }
            Console.WriteLine(littersOfWaterSum);
        }
    }
}