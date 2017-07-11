using System;

namespace _01_PokeMon
{
    class PokeMon
    {
        static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine()); //n
            int pokePowerOriginal = pokePower;
            int distance = int.Parse(Console.ReadLine()); // m  distance between poke targets
            int exhaustionFactor = int.Parse(Console.ReadLine()); //the exhaustionFactor Y – an integer.
            int targetCount = 0; //

            while (pokePower >= distance)
            {
                pokePower = pokePower - distance;
                targetCount++;

                if (pokePower == 0.5 * pokePowerOriginal && exhaustionFactor != 0)
                {
                    pokePower = pokePower / exhaustionFactor;
                }

            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targetCount);
        }
    }
}
