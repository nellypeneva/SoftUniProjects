using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; 

namespace _05_WriteToFile
{
    public class WriteToFile
    {
        public static void Main()
        {

            string[] lines = File.ReadAllLines(@"..\..\..\resources\sample_text.txt");
            char[] symbols = { '.', ',', '!', '?', ':' };
            List<string> wordsOnly = new List<string>();

            foreach (string line in lines)
            {
                var words = line.Split(symbols, StringSplitOptions.RemoveEmptyEntries); 
                string lineWords = String.Join("", words).Trim();
                wordsOnly.Add(lineWords);
            }

            File.WriteAllLines(@"..\..\..\resources\output-sample05.txt", wordsOnly);
        }
    }
}
