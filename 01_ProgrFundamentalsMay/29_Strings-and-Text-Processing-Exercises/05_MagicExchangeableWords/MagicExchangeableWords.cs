using System;
using System.Collections.Generic;
using System.Linq; 

namespace _05_MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            Dictionary<char, char> symbols = new Dictionary<char, char>();
            string first = input[0];
            string second = input[1];
            bool isExchangeable = true;

            int minLength = Math.Min(first.Length, second.Length);


            for (int i = 0; i < minLength; i++)
            {
                char char1 = first[i];
                char char2 = second[i];

                if (symbols.ContainsKey(char1))
                {
                    if (symbols[char1] != char2)
                    {
                        isExchangeable = false;
                        break;
                    }
                }
                else
                {
                    if (symbols.ContainsValue(char2))
                    {
                        isExchangeable = false;
                        break;
                    }
                    else
                    {
                        symbols[char1] = char2;  
                    }                    
                }               
            }

            string longerLine = first;

            if (second.Length > first.Length)
            {
                longerLine = second;
            }

            for (int i = minLength; i < longerLine.Length; i++)
            {
                if (!symbols.ContainsValue(longerLine[i]) && !symbols.ContainsKey(longerLine[i]))
                {
                    isExchangeable = false;
                    break;
                }
            }

            Console.WriteLine(isExchangeable.ToString().ToLower());
        }
    }
}
