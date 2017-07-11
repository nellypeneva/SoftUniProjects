using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_PokemonDontGo
{
    class PokemonDontGo
    {
        static void Main()
        {
            List<long> distanceToPockemons = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            long sumOfRemovedElements = 0;

            while (distanceToPockemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                //You must INCREASE the value of all elements in the sequence which are LESS or EQUAL 
                //to the removed element, with the value of the removed element.
                if (index < 0)
                {
                    //If the given index is LESS than 0, remove the first element of the sequence, 
                    //and COPY the last element to its place.
                    long element = distanceToPockemons[0];
                    distanceToPockemons[0] = distanceToPockemons[distanceToPockemons.Count - 1];
                    IncreaseDecreaselements(element, distanceToPockemons);
                    sumOfRemovedElements += element;
                }
                else if (index >= distanceToPockemons.Count)
                {
                    //If the given index is GREATER than the last index of the sequence, 
                    //remove the last element from the sequence, and COPY the first element to its place.
                    long element = distanceToPockemons[distanceToPockemons.Count - 1];
                    distanceToPockemons[distanceToPockemons.Count - 1] = distanceToPockemons[0];
                    IncreaseDecreaselements(element, distanceToPockemons);
                    sumOfRemovedElements += element;
                }
                else
                {
                    long element = distanceToPockemons[index];
                    distanceToPockemons.RemoveAt(index);
                    IncreaseDecreaselements(element, distanceToPockemons);
                    sumOfRemovedElements += element;
                }
            }

            Console.WriteLine(sumOfRemovedElements);
        }


        private static void IncreaseDecreaselements(long element, List<long> sequence)
        {
            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] <= element)
                {
                    sequence[i] += element;
                }
                else
                {
                    sequence[i] -= element;
                }
            }
        }
    }
}