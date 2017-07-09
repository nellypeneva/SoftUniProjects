using System;
using System.Collections.Generic;
using System.Linq; 

namespace _08_UpgradedMatcher
{
    public class UpgradedMatcher
    {
        public static void Main()
        {

            string[] products = Console.ReadLine().Split(' ');
            long[] qty = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            string line = Console.ReadLine();

            while (line.ToLower() != "done")
            {
                string[] productLine = line.Split(' ');
                string currentProduct = productLine[0];
                int index = Array.IndexOf(products, currentProduct);
                long requiredQty = long.Parse(productLine[1]); 

                if (index >= 0 && index < prices.Length)
                {
                    if (index < qty.Length && qty[index] >= requiredQty)
                    {
                        qty[index] -= requiredQty;
                        Console.WriteLine("{0} x {1} costs {2:f2}", currentProduct, requiredQty, prices[index] * requiredQty); 
                    }
                    else
                    {
                        Console.WriteLine("We do not have enough {0}", currentProduct);
                    }
                }

                line = Console.ReadLine();
            }
        }
    }
}
