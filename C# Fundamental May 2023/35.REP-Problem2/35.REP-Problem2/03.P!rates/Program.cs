namespace _03.P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cityInput = string.Empty;
            Dictionary<string, City> cities = new Dictionary<string, City>();
            while ((cityInput = Console.ReadLine()) != "Sail")
            {
                string[] cityTokens = cityInput
                    .Split("||");
                string cityName = cityTokens[0];
                int population = int.Parse(cityTokens[1]);
                int gold = int.Parse(cityTokens[2]);
                City currentCity = new City(cityName, population, gold);
                if (!cities.ContainsKey(cityName))
                {
                    cities.Add(cityName, currentCity);
                }
                else
                {
                    cities[cityName].Population += population;
                    cities[cityName].Gold += gold;
                }
            }
            string action = string.Empty;
            while ((action = Console.ReadLine()) != "End")
            {
                string[] actionTokens = action
                    .Split("=>");
                string currentAction = actionTokens[0];
                string currentCityName = actionTokens[1];
                switch (currentAction)
                {
                    case "Plunder":
                        int currentCityPeopleKilled = int.Parse(actionTokens[2]);
                        int currentCityGoldPlundered = int.Parse(actionTokens[3]);
                        Console.WriteLine($"{currentCityName} plundered! {currentCityGoldPlundered} gold stolen, {currentCityPeopleKilled} citizens killed.");
                        cities[currentCityName].Population -= currentCityPeopleKilled;
                        cities[currentCityName].Gold -= currentCityGoldPlundered;
                        if (cities[currentCityName].Population <= 0 || cities[currentCityName].Gold <= 0)
                        {
                            Console.WriteLine($"{cities[currentCityName].Name} has been wiped off the map!");
                            cities.Remove(currentCityName);
                        }

                        break;
                    case "Prosper":
                        int currentCityGoldIncreased = int.Parse(actionTokens[2]);
                        if (currentCityGoldIncreased < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }

                        else
                        {
                            cities[currentCityName].Gold += currentCityGoldIncreased;
                            Console.WriteLine($"{currentCityGoldIncreased} gold added to the city treasury. {currentCityName} now has {cities[currentCityName].Gold} gold.");
                        }

                        break;
                }
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (City city in cities.Values)
                {
                    Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
    public class City
    {
        public City(string name, int population, int gold)
        {
            Name = name;
            Population = population;
            Gold = gold;
        }

        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
}