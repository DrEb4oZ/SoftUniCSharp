using System.Runtime.CompilerServices;

namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int targetDistance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int pokeCount = 0;
            int gradualyExhaustion = pokePower / 2;
            while (pokePower >= targetDistance)
            {
                pokePower -= targetDistance;
                pokeCount++;
                if (pokePower == gradualyExhaustion && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
                
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokeCount);
        }
    }
}