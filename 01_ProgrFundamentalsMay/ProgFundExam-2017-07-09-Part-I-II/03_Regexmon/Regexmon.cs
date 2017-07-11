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

            int count = 1;

            while (true)
            {
                string pattern = (count % 2 != 0) ? patternFirstPokemon : patternSecondPokemon;
                Match match = Regex.Match(input, pattern);

                if (!match.Success)
                {
                    break;
                }

                Console.WriteLine(match.Groups[1].Value);
                count++;             
                input = input.Substring(match.Index + match.Groups[1].Value.Length);
            }
        }
    }
}
 