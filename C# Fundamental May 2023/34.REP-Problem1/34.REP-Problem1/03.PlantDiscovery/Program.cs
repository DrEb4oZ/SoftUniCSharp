/*
3
Arnoldii<->4
Woodii<->7
Welwitschia<->2
Rate: Woodii - 10
Rate: Welwitschia - 7
Rate: Arnoldii - 3
Rate: Woodii - 5
Update: Woodii - 5
Reset: Arnoldii
Exhibition
*/


namespace _03.PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int plantsCount = int.Parse(Console.ReadLine());
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();
            for (int i = 0; i < plantsCount; i++)
            {
                string currentPlant = Console.ReadLine();
                string[] plantTokens = currentPlant.Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plantName = plantTokens[0];
                int plantRating = int.Parse(plantTokens[1]);
                if (!plants.ContainsKey(plantName))
                {
                    Plant plant = new Plant(plantName, plantRating, new List<decimal>());
                    plants.Add(plantName, plant);
                }
                else
                {
                    plants[plantName].Rarity = plantRating;
                }
            }
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] commandTokens = command.Split(new char[] { ':', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = commandTokens[0];
                string currentPlant = commandTokens[1];
                if (!plants.ContainsKey(currentPlant))
                {
                    Console.WriteLine("error");
                    continue;
                }

                switch (currentCommand)
                {
                    case "Rate":

                        decimal rating = decimal.Parse(commandTokens[2]);
                        plants[currentPlant].Rating.Add(rating);
                        break;
                    case "Update":
                        int newRarity = int.Parse(commandTokens[2]);
                        plants[currentPlant].Rarity = newRarity;
                        break;
                    case "Reset":
                        plants[currentPlant].Rating.RemoveRange(0, plants[currentPlant].Rating.Count);
                        break;
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (Plant plant in plants.Values)
            {
                if (plant.Rating.Count == 0)
                {
                    plant.Rating.Add(0.00m);
                }
                Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {plant.Rating.Average():f2}");
            }
        }
        public class Plant
        {
            public Plant(string name, int rarity, List<decimal> rating)
            {
                Name = name;
                Rarity = rarity;
                Rating = rating;
            }

            public string Name { get; set; }
            public int Rarity { get; set; }
            public List<decimal> Rating { get; set; }
            
        }
    }
}