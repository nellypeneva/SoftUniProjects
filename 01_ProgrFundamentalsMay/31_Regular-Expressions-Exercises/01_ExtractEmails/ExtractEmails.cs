using System; 
using System.Text.RegularExpressions; 

namespace _01_ExtractEmails
{
    public class ExtractEmails
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            //string pattern = @"(\s|^)([a-z0-9]+)([-._][a-z0-9]+)?@([a-z]+\-?[a-z]+\.)?([a-z]+\-?[a-z]+\.[a-z]+)"; //me  

            //string pattern = @"(?<=\s)[a-z0-9]+([-.]\w*)*@[a-z]+([-.]\w*)*(\.[a-z]+)"; //vasil damyanov

            //last test
            string pattern = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@(?:[a-z]+\-?[a-z]+\.)+[a-z]+\-?[a-z]+)\b";
            //match also  email like:   mail-01.info-bg@software-university.soft-ware.academy


            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value.Trim());
            }
            
        }
    }
}
