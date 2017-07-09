using System;
using System.Collections.Generic;
using System.Linq; 

namespace _07_InventoryMatcher
{
    public class InventoryMatcher
    {
        public static void Main()
        {
            string[] products = Console.ReadLine().Split(' ');
            long[] qty = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            string line = Console.ReadLine();

            while (line.ToLower() != "done")
            {
                int index = Array.IndexOf(products, line);

                if (index >= 0 && index < qty.Length && index < prices.Length) 
                {
                    Console.WriteLine("{0} costs: {1}; Available quantity: {2}", line, prices[index], qty[index]);
                }

                line = Console.ReadLine();
            }
        }
    }
}
