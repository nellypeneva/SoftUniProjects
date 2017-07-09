using System;
using System.Linq;
using System.Text.RegularExpressions; 

namespace _05_KeyReplacer
{
    public class KeyReplacer
    {
        public static void Main()
        { 
            string keyPattern = @"^([A-Za-z]+)[\|<\\]{1}(?:.+)[\|<\\]{1}([A-Za-z]+)$";

            string keyLine = Console.ReadLine();   
            string input = Console.ReadLine();

            Regex regex = new Regex(keyPattern);
            if (regex.IsMatch(keyLine))
            {
                Match match = regex.Match(keyLine); 
                string start = match.Groups[1].Value;
                string end = match.Groups[match.Groups.Count-1].Value;

                string pattern= String.Format(start + "(.*?)" + end);

                Regex rgx = new Regex(pattern);
                MatchCollection matches = rgx.Matches(input);

                string[] result = matches.Cast<Match>().Select(a => a.Groups[1].Value).Where(a => a != String.Empty).ToArray();  

                if (result.Length > 0)
                {
                    Console.WriteLine(string.Join("", result));                    
                }
                else
                {
                    Console.WriteLine("Empty result");
                }  
            } 
        }
    }
}
