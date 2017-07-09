using System;
using System.Collections.Generic; 

namespace _02_RandomizeWords
{
    public class RandomizeWords
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            Random rnd = new Random(); 

            for (int i = 0; i < input.Length; i++)
            {
                string currentWord = input[i];
                int index = rnd.Next(0, input.Length);
                var tempWord = input[index];
                input[i] = tempWord;
                input[index] = currentWord; 
            }

            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
