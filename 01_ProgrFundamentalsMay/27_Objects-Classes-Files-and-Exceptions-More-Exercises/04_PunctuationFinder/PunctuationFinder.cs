using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; 

namespace _04_PunctuationFinder
{
    public class PunctuationFinder
    {
        public static void Main()
        {
            string[] lines = File.ReadAllLines(@"..\..\..\resources\sample_text.txt");
            char[] symbols = {'.', ',', '!', '?', ':' };
            List<char> punctuations = new List<char>();

            foreach (string line in lines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (symbols.Contains(line[i]))
                    {
                        punctuations.Add(line[i]);
                    }
                } 
            }

            Console.WriteLine(String.Join(", ", punctuations));
            //File.WriteAllText(@"..\..\..\resources\output-sample.txt", String.Join(", ", punctuations));
        }
    }
}



//