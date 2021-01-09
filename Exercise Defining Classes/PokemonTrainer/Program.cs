using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Trainer> trainers = new List<Trainer>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input== "Tournament")
                {
                    break;
                }
                else
                {
                    var caugthPokemonInfo = input
                        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    var trainerName = caugthPokemonInfo[0];
                    var pokemonName = caugthPokemonInfo[1];
                    var pokemonElement = caugthPokemonInfo[2];
                    var pokemonHealth = int.Parse(caugthPokemonInfo[3]);
                    int trainerBadges = 0;
                    Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                   

                    if (trainers.Any(t=>t.Name==trainerName))
                    {
                        foreach (var trainer in trainers)
                        {
                            if (trainer.Name==trainerName)
                            {
                                trainer.CaugthPokemons.Add(pokemon);
                            }
                        }
                    }
                    else
                    {
                        List<Pokemon> caugthPokemons = new List<Pokemon>();
                        caugthPokemons.Add(pokemon);
                        Trainer trainer = new Trainer(trainerName, trainerBadges, caugthPokemons);
                        trainers.Add(trainer);
                    }

                }
            }

            while (true)
            {
                string elementName = Console.ReadLine();

                if (elementName== "End")
                {
                    break;
                }
                else
                {
                    foreach (var trainer in trainers)
                    {

                        if (trainer.CaugthPokemons.Any(p=>p.Element==elementName))
                        {
                            trainer.NumberBadges++;
 
                        }


                        if (trainer.CaugthPokemons.All(p => p.Element != elementName))
                        {

                            for (int i = 0; i < trainer.CaugthPokemons.Count; i++)
                            {
                                trainer.CaugthPokemons[i].Health -= 10;
                                if (trainer.CaugthPokemons[i].Health<=0)
                                {
                                    trainer.CaugthPokemons.Remove(trainer.CaugthPokemons[i]);
                                    i--;

                                }
                            }


                        }
                    }
                }
            }

            foreach (var trainer in trainers.OrderByDescending(t=>t.NumberBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberBadges} {trainer.CaugthPokemons.Count}");
            }

        }
    }
}
