using System;
using System.Collections.Generic;
using System.Linq; 

namespace _03_MinerTask
{
    public class MinerTask
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, long> resources = new Dictionary<string, long>();  

            while (input != "stop")
            {
                long qty = long.Parse(Console.ReadLine());

                if (!resources.ContainsKey(input))
                {
                    resources[input] = 0;
                }

                resources[input] += qty;

                input = Console.ReadLine(); 
            }

            foreach (var item in resources)
            {
                 Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
 