using System;
using System.Text.RegularExpressions;

namespace _03_Regexmon
{
    class Regexmon
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string patternFirstPokemon = @"([^A-Za-z\-]+)";
            string patternSecondPokemon = @"([A-Za-z]+-[A-Za-z]+)";
            Regex rgx1 = new Regex(patternFirstPokemon);
            Regex rgx2 = new Regex(patternSecondPokemon);
            int count = 1;
            int startIndex = 0;
            while (true)
            {
                Regex rgx = (count % 2 != 0) ? rgx1 : rgx2;
                Match match = rgx.Match(input, startIndex);

                if (!match.Success)
                {
                    break;
                }

                Console.WriteLine(match.Groups[1].Value);
                count++;
                startIndex = match.Index + match.Groups[1].Value.Length; 
            }
        }
    }
}
