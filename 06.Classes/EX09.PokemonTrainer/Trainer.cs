using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX09.PokemonTrainer
{
    internal class Trainer
    {
        public Trainer(string trainerName)
        {
            TrainerName = trainerName;
            Badges = 0;
            Pokemons = new List<Pokemon> { };
        }

        public string TrainerName { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }
    }
}
