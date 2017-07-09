using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_SplitByWordCasing
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
                if (IsAllLower(word)) // all small case letters
                {
                    lowerCase.Add(word);
                }
                else if (IsAllUpper(word)) // all upper case letters
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

        public static bool IsAllUpper(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (!Char.IsUpper(word[i]))
                    return false;
            }

            return true;
        }

        public static bool IsAllLower(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (!Char.IsLower(word[i]))
                    return false;
            }

            return true;
        }

    }
}