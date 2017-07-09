using System;
using System.Collections.Generic;
using System.Linq; 

namespace _02_SoftUniKaraoke
{
    public class SoftUniKaraoke
    {
        public static void Main()
        {             
            string[] singers = Console.ReadLine().Split(',').Select(x=>x.Trim()).ToArray();  
            string[] songs = Console.ReadLine().Split(',').Select(x=>x.Trim()).ToArray();

            Dictionary<string, HashSet<string>> singerAwards = new Dictionary<string, HashSet<string>>(); 

            while (true)
            {
               string input = Console.ReadLine();

               if (input=="dawn")
               {
                    break;
               }

               string[] parameters = input.Split(',').Select(x => x.Trim()).ToArray();
               string name = parameters[0];
               string song = parameters[1];
               string award = parameters[2];

               if (!songs.Contains(song) || !singers.Contains(name))
               {
                   continue;
               }

               if (!singerAwards.ContainsKey(name))
               {
                   singerAwards[name] = new HashSet<string>();
               }

               singerAwards[name].Add(award);              
            }

            singerAwards = singerAwards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            printResults(singerAwards);
           
        }

       
        public static void printResults(Dictionary<string, HashSet<string>> singerAwards)
        {
            if (0 == singerAwards.Count)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (var item in singerAwards)
            {
                Console.WriteLine("{0}: {1} awards", item.Key, item.Value.Count);

                foreach (var award in item.Value.OrderBy(x=>x))
                {
                    Console.WriteLine("--{0}", award);
                }
            }
        }
    }
}
