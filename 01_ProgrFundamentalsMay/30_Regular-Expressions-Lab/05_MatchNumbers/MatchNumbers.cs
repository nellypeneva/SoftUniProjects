using System; 
using System.Text.RegularExpressions;

namespace _05_MatchNumbers
{
    public class MatchNumbers
    {
        public static void Main()
        {
            // http://www.regular-expressions.info/lookaround.html  

            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
