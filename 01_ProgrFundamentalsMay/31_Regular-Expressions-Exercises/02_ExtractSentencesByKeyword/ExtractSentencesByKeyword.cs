using System;
using System.Text.RegularExpressions; 

namespace _02_ExtractSentencesByKeyword
{
    public class ExtractSentencesByKeyword
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            string patternSentence = @"([^.!?]+)([.!?]+)";   
            string patternKeyword = String.Format(@"(\b" + word + @"\b)");

            Regex regSentence = new Regex(patternSentence);
            Regex regKeyword = new Regex(patternKeyword);

            MatchCollection matches = regSentence.Matches(input);

            foreach (Match match in matches)
            {
                string value = match.Groups[1].Value.Trim();
                if (regKeyword.IsMatch(value))
                {
                    Console.WriteLine(value);
                } 
            }
        }
    }
}

