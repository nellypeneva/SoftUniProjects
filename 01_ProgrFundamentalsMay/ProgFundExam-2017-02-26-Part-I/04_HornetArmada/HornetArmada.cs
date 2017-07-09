using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04_HornetArmada
{
    public class HornetArmada
    {
        public static void Main()
        {
            //{lastActivity} = {legionName} -> {soldierType}:{soldierCount}
            string pattern = @"^(\d+) = (.+) -> (.+):(\d+)$";
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Legion> results = new Dictionary<string, Legion>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match m = Regex.Match(input, pattern);
                if (m.Success)
                {

                    int lastAcativity = int.Parse(m.Groups[1].Value);
                    string legionName = m.Groups[2].Value;
                    string solgierType = m.Groups[3].Value;
                    int solgierNum = int.Parse(m.Groups[4].Value);

                    if (!results.ContainsKey(legionName))
                    {
                        results[legionName] = new Legion();
                    }

                    if (results[legionName].LastActivity < lastAcativity)
                    {
                        results[legionName].LastActivity = lastAcativity;
                    }

                    if (!results[legionName].SolgierTypes.ContainsKey(solgierType))
                    {
                        results[legionName].SolgierTypes[solgierType] = 0;
                    }

                    results[legionName].SolgierTypes[solgierType] += solgierNum;
                }
            }

            string pattern1 = @"(\d+)\\(.+)";
            string line = Console.ReadLine();
            Match match = Regex.Match(line, pattern1);
            if (match.Success)
            {
                 int activity = int.Parse(match.Groups[1].Value);
                 string soldierType = match.Groups[2].Value; 

                 var result = results.Where(x => (x.Value.LastActivity < activity && x.Value.SolgierTypes.ContainsKey(soldierType)))
                                    .OrderByDescending(x => x.Value.SolgierTypes[soldierType])
                                    .ToDictionary(x => x.Key, x => x.Value);

                 foreach (var item in result)
                 {
                     Console.WriteLine("{0} -> {1}", item.Key, item.Value.SolgierTypes[soldierType]);
                 }
            }
            else
            {
                string soldierType = line;
                var result = results.Where(x => x.Value.SolgierTypes.ContainsKey(soldierType))
                                    .OrderByDescending(x => x.Value.LastActivity)
                                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var item in result)
	            {
		            Console.WriteLine("{0} : {1}", item.Value.LastActivity, item.Key);
	            } 
            } 
        }
    } 

    public class Legion
    {
        public Legion() 
        {
            this.LastActivity = 0;
            this.SolgierTypes = new Dictionary<string, long>();
        }
         
        public int LastActivity { get; set; }
        public Dictionary<string, long> SolgierTypes { get; set; }
    }
} 
