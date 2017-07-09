using System;  
using System.Text.RegularExpressions; 

namespace _04_MatchDates
{
    public class MatchDates
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";   
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;

                Console.WriteLine("Day: {0}, Month: {1}, Year: {2}", day, month, year);
            }
        }
    }
}
