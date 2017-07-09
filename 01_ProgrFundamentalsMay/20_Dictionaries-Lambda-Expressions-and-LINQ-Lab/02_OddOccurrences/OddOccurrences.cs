using System;
using System.Collections.Generic;
using System.Linq; 

namespace _02_OddOccurrences
{
    public class OddOccurrences
    {
        public static void Main()
        {

            string[] input = Console.ReadLine().ToLower().Split(' ');
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (!wordCount.ContainsKey(word))
                {
                    wordCount[word] = 0;
                }

                wordCount[word]++;
            }

            List<string> words = new List<string>();

            foreach (var item in wordCount)
            {
                if (item.Value % 2 != 0) 
                {
                    words.Add(item.Key);
                }
            }

            Console.WriteLine(String.Join(", ", words));
        }
    }
}
