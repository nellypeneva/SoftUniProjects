using System;
using System.Collections.Generic;
using System.Linq;

namespace _04a_SplitByWordCasing
{
    public class SplitByWordCasing
    {
        public static void Main()
        {
            char[] separators = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };

            List<string> input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            foreach (string word in input)
            {
                if (word.All(c => char.IsLower(c))) // all small case letters
                {
                    lowerCase.Add(word);
                }
                else if (word.All(c => char.IsUpper(c))) // all upper case letters
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }

            Console.WriteLine("Lower-case: {0}", String.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", String.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", String.Join(", ", upperCase));
        }
    }
}