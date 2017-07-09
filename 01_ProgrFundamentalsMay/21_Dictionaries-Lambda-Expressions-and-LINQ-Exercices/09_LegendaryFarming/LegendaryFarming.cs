using System;
using System.Collections.Generic;
using System.Linq; 

namespace _09_LegendaryFarming
{
    public class LegendaryFarming
    {
        private static readonly Dictionary<string, string> materialsForItems = new Dictionary<string, string>
        {
            { "shards", "Shadowmourne"},
            { "fragments", "Valanyr"},
            { "motes", "Dragonwrath"}
        };

        public static void Main()
        {

            string input = Console.ReadLine();
            Dictionary<string, int> keyMaterials = new Dictionary<string, int> 
            { 
                { "shards", 0 }, 
                { "fragments", 0 }, 
                { "motes", 0 } 
            };

            SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();

            while (!string.IsNullOrEmpty(input))
            {
                string[] line = input.Split();

                for (int i = 0; i < line.Length-1; i+=2)
                {
                    int qty = int.Parse(line[i]);
                    string material = line[i + 1].ToLower();

                    if(keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += qty;

                        if (keyMaterials[material] >= 250)
                        {
                            keyMaterials[material] -= 250;
                            Console.WriteLine("{0} obtained!", materialsForItems[material]);
                            var materials = keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

                            foreach (var pair in materials)
                            {
                                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
                            }

                            foreach (var pair in junkMaterials)
                            {
                                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
                            }

                            return;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }

                        junkMaterials[material] += qty;
                    } 
                    
                }

                input = Console.ReadLine();
            }
        }
    }
}