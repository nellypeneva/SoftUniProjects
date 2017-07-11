using System;
//using System.Collections.Generic;
using System.Linq;

namespace _03_HornetAssault
{
    public class HornetAssault
    {
        public static void Main()
        {
            long[] bees = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long[] hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            if (hornets.Length==0)
            {
                 Console.WriteLine(String.Join(" ", bees));
                 return;
            }
            
            long hornetPower = hornets.Sum();

            if (hornetPower == 0)
            {
                Console.WriteLine(String.Join(" ", bees));
                return;
            }

            int hornetStartIndex = 0;

            for (int i = 0; i < bees.Length; i++)
            {
                bees[i] -= hornetPower;
                if (bees[i]>=0)
                {
                    hornetPower -= hornets[hornetStartIndex];
                    hornetStartIndex++;
                    if (hornetStartIndex >= hornets.Length)
                    {
                        break;
                    }
                }
            }

            var results = bees.Where(x => x > 0).ToArray();
            if (results.Length > 0)
            {
                Console.WriteLine(String.Join(" ", results));
            }
            else
            {
                var aliveHornets = hornets.Skip(hornetStartIndex);
                Console.WriteLine(String.Join(" ", aliveHornets));
            } 
        }
    }
}
