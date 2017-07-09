using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _10_SerbianUnleashed
{
    public class SerbianUnleashed
    {
        public static void Main()
        {

            Dictionary<string, Dictionary<string, long>> statistics = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                //"singer @venue ticketsPrice ticketsCount". 

                string correctInputPattern = @"(([a-zA-Z]+\s){1,3})@(([a-zA-Z]+\s){1,3})(\d+)\s(\d+)";

                if (!Regex.IsMatch(input, correctInputPattern))
                {
                    input = Console.ReadLine(); 
                    continue; 
                }
                 
                Match match = Regex.Match(input, correctInputPattern);

                string singer = match.Groups[1].Value.Trim();
                string venue = match.Groups[3].Value.Trim();
                int ticketsPrice = int.Parse(match.Groups[5].Value);
                int ticketsCount = int.Parse(match.Groups[6].Value); 

                if (!statistics.ContainsKey(venue))
                {
                    statistics[venue] = new Dictionary<string, long>();
                }

                if (!statistics[venue].ContainsKey(singer))
                {
                    statistics[venue][singer] = 0;
                }

                statistics[venue][singer] += ticketsPrice * ticketsCount;

                input = Console.ReadLine();
            }


            foreach (var item in statistics)
            {
                Console.WriteLine(item.Key);

                var signers = item.Value.OrderByDescending(x => x.Value);

                foreach (var pair in signers)
                {
                    Console.WriteLine("#  {0} -> {1}", pair.Key, pair.Value);
                }
            }
        }
    }
}