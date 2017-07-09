using System;
using System.Text.RegularExpressions;
namespace _02_EmailMe
{
    public class EmailMe
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(.+)\@(.+)";

            Regex rgx = new Regex(pattern);
            Match match = rgx.Match(input);

            int sumLeft = sumLetters(match.Groups[1].Value);
            int sumRight = sumLetters(match.Groups[2].Value);

            if (sumLeft - sumRight>=0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }

        public static int sumLetters(string word)
        {
            int sum = 0;
            foreach (char c in word)
            {
                sum += (int)c;
            }
            return sum;
        }
    }
}
