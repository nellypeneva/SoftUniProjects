using System; 
using System.Linq;
using System.Text.RegularExpressions; 

namespace _03_MatchHexadecimalNumbers
{
    public class MatchHexadecimalNumbers
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";  //?: - do not make it group
            MatchCollection matches = Regex.Matches(input, pattern);
            var result = matches.Cast<Match>().Select(a => a.Value).ToArray();

            Console.WriteLine(String.Join(" ", result)); 
        }
    }
}
