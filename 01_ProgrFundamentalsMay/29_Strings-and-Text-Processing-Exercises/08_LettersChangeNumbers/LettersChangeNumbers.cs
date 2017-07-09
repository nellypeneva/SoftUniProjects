using System;
using System.Linq;
using System.Text.RegularExpressions; 

namespace _08_LettersChangeNumbers
{
    public class LettersChangeNumbers
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"([a-zA-z])(\d+)([a-zA-z])";
            MatchCollection matches = Regex.Matches(input, pattern);

            decimal sum = 0;

            foreach (Match match in matches)
            {
                char firstLetter = match.Value.First();
                char lastLetter = match.Value.Last();

                decimal number = decimal.Parse(Regex.Match(match.Value, @"\d+").Value);

                int firstLetterIndex = GetAlphabetIndex(firstLetter);
                int lastLetterIndex = GetAlphabetIndex(lastLetter);

                if (char.IsUpper(firstLetter))
                {
                    number = number / firstLetterIndex;
                }
                else if (char.IsLower(firstLetter))
                {
                    number = number * firstLetterIndex;
                }

                if (char.IsUpper(lastLetter))
                {
                    number = number - lastLetterIndex;
                }
                else if (char.IsLower(lastLetter))
                {
                    number = number + lastLetterIndex;
                }

                sum += number;
            }

            Console.WriteLine("{0:f2}", sum); 
        }

        public static int GetAlphabetIndex(char symbol)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";  //ABCDEFGHIJKLMNOPQRSTUVWXYZ
            char letter = char.ToLower(symbol);
            return (alphabet.IndexOf(letter) + 1);
        }
    }
}
