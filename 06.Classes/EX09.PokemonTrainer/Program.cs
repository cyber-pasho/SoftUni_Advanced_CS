namespace EX09.PokemonTrainer
{
    internal class Program
    {
        static void Main()
        {
            var trainers = new Dictionary<string, Trainer>();

            // Reading pokemon and trainer input
            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string trainerName = parts[0];
                string pokemonName = parts[1];
                string pokemonElement = parts[2];
                int pokemonHealth = int.Parse(parts[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName] = new Trainer(trainerName);
                }

                trainers[trainerName].Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
            }

            // Tournament phase
            while ((input = Console.ReadLine()) != "End")
            {
                string element = input;

                foreach (var trainer in trainers.Values)
                {
                    if (trainer.Pokemons.Any(p => p.PokemonElement == element))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            pokemon.PokemonHealth -= 10;
                        }

                        trainer.Pokemons = trainer.Pokemons
                            .Where(p => p.PokemonHealth > 0)
                            .ToList();
                    }
                }
            }

            // Output results
            foreach (var trainer in trainers
                .OrderByDescending(t => t.Value.Badges))
            {
                Console.WriteLine($"{trainer.Value.TrainerName} {trainer.Value.Badges} {trainer.Value.Pokemons.Count}");
            }
        }
    }
}
