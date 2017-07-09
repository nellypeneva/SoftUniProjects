using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06_EmailStatistics
{
    public class EmailStatistics
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());          
            string pattern = @"(^[a-zA-Z]{5,})@(([a-z]{3,})(\.com|\.bg|\.org)$)";

            Regex r = new Regex(pattern);
            Dictionary<string, HashSet<string>> list = new Dictionary<string, HashSet<string>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine(); 
                Match match = r.Match(input);
                if (match.Success)
                {
                    string domain = match.Groups[2].Value;
                    string user = match.Groups[1].Value;

                    if (!list.ContainsKey(domain))
                    {
                        list[domain] = new HashSet<string>();
                    }
                    list[domain].Add(user); 
                } 
            }


            var results =list.OrderByDescending(x => x.Value.Count());

            foreach (var pair in results)
            {
                Console.WriteLine("{0}:", pair.Key);

                foreach (var item in pair.Value)
                {
                    Console.WriteLine("### {0}", item);
                }
            }
        }
    }
}
