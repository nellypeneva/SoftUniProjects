using System;
using System.Collections.Generic;
using System.Linq; 

namespace _08_LogsAggregator
{
    public class LogsAggregator
    {
        public static void Main()
        {
            SortedDictionary<string, SortedDictionary<string, long>> statistics = new SortedDictionary<string, SortedDictionary<string, long>>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] parameters = Console.ReadLine().Split(' ');
                string ip = parameters[0];
                string user = parameters[1];
                long duration = long.Parse(parameters[2]);

                if (!statistics.ContainsKey(user))
                {
                    statistics[user] = new SortedDictionary<string, long>();
                }


                if (!statistics[user].ContainsKey(ip))
                {
                    statistics[user][ip] = 0;
                }

                statistics[user][ip] += duration;
            }

            foreach (var pair in statistics)
            {
               Console.WriteLine("{0}: {1} [{2}]", pair.Key, pair.Value.Values.Sum(), String.Join(", ", pair.Value.Keys));
            }
        }
    }
}