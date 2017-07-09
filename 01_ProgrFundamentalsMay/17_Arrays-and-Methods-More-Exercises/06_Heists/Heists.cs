using System;
using System.Collections.Generic;
using System.Linq; 

namespace _06_Heists
{
    public class Heists
    {
        public static void Main()
        {
            long[] prices = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long jewelsPrice = prices[0];
            long goldPrice = prices[1];
            long totalExpences = 0;
            long totalEarnings = 0;

            string input = Console.ReadLine();

            while (input != "Jail Time") 
            {
               string[] line = input.Split(' ');
               string items = line[0];
               int currentExpences = int.Parse(line[1]);

               int numGold = items.Count(x => x == '$');
               int numJewel = items.Count(x => x == '%');

               totalExpences += currentExpences;
               totalEarnings += (numGold * goldPrice + numJewel * jewelsPrice);

               input = Console.ReadLine();  
            }

            long total = totalEarnings - totalExpences;

            string result = String.Format("Heists will continue. Total earnings: {0}.", total);

            if (total<0)
            {
                result=String.Format("Have to find another job. Lost: {0}.", Math.Abs(total));
            }

            Console.WriteLine(result);             
        }
    }
}
