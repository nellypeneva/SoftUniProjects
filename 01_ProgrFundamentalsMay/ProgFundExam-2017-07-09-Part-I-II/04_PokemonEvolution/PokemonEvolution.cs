using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_PokemonEvolution
{
    class PokemonEvolution
    {
        static void Main()
        {
            //The pokemonName and evolutionType are strings which may contain any ASCII character  (except ‘-’, ‘ ’, ‘>’).
            Dictionary<string, List<Pokemon>> pokemons = new Dictionary<string, List<Pokemon>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "wubbalubbadubdub")
                {
                    break;
                }

                string[] parameters = input.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string pokemonName = parameters[0];

                if (parameters.Length == 1)
                {
                    //find pockemon name if exists and print ...

                    if (pokemons.ContainsKey(pokemonName))
                    {
                        List<Pokemon> result = pokemons[pokemonName];
                        Console.WriteLine("# {0}", pokemonName);

                        foreach (var item in result)
                        {
                            Console.WriteLine("{0} <-> {1}", item.EvolutionType, item.EvolutionIndex);
                        }
                    }

                    continue;
                }

                //{pokemonName} -> {evolutionType} -> {evolutionIndex} 
                string evolutionType = parameters[1];
                long evolutionIndex = long.Parse(parameters[2]);

                if (!pokemons.ContainsKey(pokemonName))
                {
                    pokemons[pokemonName] = new List<Pokemon>();
                }

                pokemons[pokemonName].Add(new Pokemon(pokemonName, evolutionType, evolutionIndex));
            }

            foreach (var item in pokemons)
            {
                Console.WriteLine("# {0}", item.Key);
                List<Pokemon> result = item.Value;
                result = result.OrderByDescending(x => x.EvolutionIndex).ToList();

                foreach (var p in result)
                {
                    Console.WriteLine("{0} <-> {1}", p.EvolutionType, p.EvolutionIndex);
                }
            }
        }
    }


    public class Pokemon
    {
        public Pokemon(string name, string evolutionType, long evolutionIndex)
        {
            this.Name = Name;
            this.EvolutionType = evolutionType;
            this.EvolutionIndex = evolutionIndex;
        }
        public string Name { get; set; }
        public string EvolutionType { get; set; }
        public long EvolutionIndex { get; set; }
    }
}