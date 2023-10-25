using System.ComponentModel.Design;

namespace _05.CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continentsCountriesCities = new Dictionary<string, Dictionary<string, List<string>>>();
            int pairsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < pairsCount; i++)
            {
                string[] currentPair = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = currentPair[0];
                string country = currentPair[1];
                string city = currentPair[2];
                if (!continentsCountriesCities.ContainsKey(continent))
                {
                    continentsCountriesCities.Add(continent, new Dictionary<string, List<string>>());
                    if (!continentsCountriesCities[continent].ContainsKey(country))
                    {
                        continentsCountriesCities[continent].Add(country, new List<string>());
                    }
                }

                else if (!continentsCountriesCities[continent].ContainsKey(country))
                {
                    continentsCountriesCities[continent].Add(country, new List<string>());
                }
                continentsCountriesCities[continent][country].Add(city);
            }

            foreach (KeyValuePair<string,Dictionary<string,List<string>>> continentCountryCities in continentsCountriesCities)
            {
                Console.WriteLine($"{continentCountryCities.Key}:");
                foreach (KeyValuePair<string,List<string>> country in continentCountryCities.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}