using System;
using System.Linq;
using System.Text.RegularExpressions; 

namespace _02_MatchPhoneNumber
{
    public class MatchPhoneNumber
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"\+359(\s|-)2\1[0-9]{3}\1[0-9]{4}";
            //string pattern = @"\s?\+359(\s|-)2\1[0-9]{3}\1[0-9]{4}";
            MatchCollection matches = Regex.Matches(input, pattern);

            var result = matches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(String.Join(", ", result)); 
        }
    }
}
