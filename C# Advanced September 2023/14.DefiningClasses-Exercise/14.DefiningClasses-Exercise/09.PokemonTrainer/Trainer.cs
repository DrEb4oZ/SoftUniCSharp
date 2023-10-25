using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string trainerName;
        private int numberOfBadges = 0;
        private List<Pokemon> pokemons;


        public Trainer(string trainerName, string pokemonName, string elemental, int pokemonHealth)
        {
            this.trainerName = trainerName;
            this.NumberOfBadges = numberOfBadges;
            //Pokemon pokemon = new Pokemon(pokemonName, elemental, pokemonHealth);
            this.Pokemons = new List<Pokemon>();
        }

        public string TrainerName
        {
            get
            {
                return this.trainerName;
            }
            set
            {
                this.trainerName = value;
            }
        }

        public int NumberOfBadges
        {
            get
            {
                return this.numberOfBadges;
            }
            set
            {
                this.numberOfBadges = value;
            }
        }

        public List<Pokemon> Pokemons
        {
            get
            {
                return this.pokemons;
            }
            set
            {
                this.pokemons = value;
            }
        }

    }

}
