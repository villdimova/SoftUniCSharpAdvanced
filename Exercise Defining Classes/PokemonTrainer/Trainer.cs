using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    class Trainer
    {
        public string Name { get; set; }

        public int NumberBadges { get; set; }

        public List<Pokemon> CaugthPokemons { get; set; }

        public Trainer(string name, int numberBadges,List<Pokemon> caugthPokemons)
        {
            this.Name = name;
            this.NumberBadges = numberBadges;
            this.CaugthPokemons = caugthPokemons;
        }
    }
}
