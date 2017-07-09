using System;
using System.Collections.Generic;
using System.Text.RegularExpressions; 

namespace _07_QueryMess
{
    public class QueryMess
    {
        public static void Main()
        {
            string pattern = @"([^?=&]+)=([^?=&]+)";
            string pattern2 = @"(%20|\+)+"; 
            Regex regex = new Regex(pattern);
            Regex rgx = new Regex(pattern2);
           
            string input = Console.ReadLine();

            while (input != "END")
            {
                Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();
                MatchCollection matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    string key = match.Groups[1].Value;
                    key = rgx.Replace(key," ").Trim();
                    string val = match.Groups[2].Value;
                    val = rgx.Replace(val, " ").Trim();

                    if (!results.ContainsKey(key))
                    {
                        results[key] = new List<string>();
                    }
                    results[key].Add(val);
                }

                foreach (var pair in results)
                {
                    Console.Write("{0}=[{1}]", pair.Key, string.Join(", ", pair.Value));
                }
                Console.WriteLine();
                input = Console.ReadLine();
            }
        }
    }
}
//what is the diference between (%20|\+)+  and [%20|\+]+
//(^|(?<=[\r\n\?\&\+]))[^\?\&\=]+?\=[^\?\&\=]+?($|(?=[\?\&\n\r\=]))
