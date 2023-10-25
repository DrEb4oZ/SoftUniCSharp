using System.Transactions;
/*
Peter Charizard Fire 100
George Squirtle Water 38
Peter Pikachu Electricity 10
Tournament
Fire
Water
End

 */
namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Tournament")
            {
                string[] trainerProperties = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (trainerProperties.Length < 4) continue;
                string trainerName = trainerProperties[0];
                string pokemonName = trainerProperties[1];
                string pokemonElemental = trainerProperties[2];
                int pokemonHealth = int.Parse(trainerProperties[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName, pokemonName, pokemonElemental, pokemonHealth));
                }

                Pokemon newPokemon = new Pokemon(pokemonName, pokemonElemental, pokemonHealth);
                trainers[trainerName].Pokemons.Add(newPokemon);
            }
            while ((command = Console.ReadLine()) != "End")
            {
                PokemonElementAction(command, trainers);
            }

            foreach (Trainer trainer in trainers.Values.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.TrainerName} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
        static void PokemonElementAction(string command, Dictionary<string, Trainer> trainers)
        {
            foreach (Trainer trainer in trainers.Values)
            {
                if (trainer.Pokemons.Any(x => x.Element == command))
                {
                    trainer.NumberOfBadges++;
                }

                else
                {
                    List<Pokemon> tempPokemons = new List<Pokemon>();
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        tempPokemons.Add(pokemon);
                    }
                    foreach (Pokemon pokemon in trainer.Pokemons)
                    {
                        pokemon.PokemonHealth -= 10;
                        if (pokemon.PokemonHealth <= 0)
                        {
                            tempPokemons.Remove(pokemon);
                            //trainer.Pokemons.Remove(pokemon);
                        }
                    }
                    trainer.Pokemons = tempPokemons;
                }
            }
            
        }
    }

}