using System;
using System.Collections.Generic;
using System.Linq; 

namespace _11_DragonArmy
{
    public class DragonArmy
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var dragons = new Dictionary<string, SortedDictionary<string, int[]>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string type = input[0];
                string name = input[1];
                
                int damage = ("null" == input[2]) ? 45 : int.Parse(input[2]);
                int health = ("null" == input[3]) ? 250 : int.Parse(input[3]);                
                int armor = ("null" == input[4]) ? 10 : int.Parse(input[4]);

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, int[]>();
                }

                dragons[type][name] = new int[3] { damage, health, armor };  
            }

            foreach (var pair in dragons)
            {
                var dragonType = pair.Key;
                var avgDamage = pair.Value.Values.Average(x => x[0]);
                var avgHealth = pair.Value.Values.Average(x => x[1]);
                var avgArmor = pair.Value.Values.Average(x => x[2]);

                Console.WriteLine("{0}::({1:f2}/{2:f2}/{3:f2})", dragonType, avgDamage, avgHealth, avgArmor);

                foreach (var item in pair.Value)
                {
                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}", item.Key, item.Value[0], item.Value[1], item.Value[2]);
                }
            } 
        }
    }
}
