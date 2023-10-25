using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public class Pokemon
    {
        private string pokemonName;
        private string element;
        private int pokemonHealth;


        public Pokemon(string pokemonName, string element, int pokemonHealth)
        {
            this.PokemonName = pokemonName;
            this.Element = element;
            this.PokemonHealth = pokemonHealth;
        }

        public string PokemonName
        {
            get
            {
                return this.pokemonName;
            }
            set
            {
                this.pokemonName = value;
            }
        }

        public string Element
        {
            get
            {
                return this.element;
            }
            set
            {
                this.element = value;
            }
        }

        public int PokemonHealth
        {
            get
            {
                return this.pokemonHealth;
            }
            set
            {
                this.pokemonHealth = value;
            }
        }
    }
}
