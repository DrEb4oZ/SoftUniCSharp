using System.Numerics;
using System.Runtime.InteropServices;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballCount = int.Parse(Console.ReadLine());
            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;
            BigInteger bestSnowballValue = 0;
            for (int i = 0; i < snowballCount; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger currnetSnowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                if (bestSnowballValue < currnetSnowballValue)
                {
                    bestSnowballValue = currnetSnowballValue;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                }

            }

            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");
        }
    }
}