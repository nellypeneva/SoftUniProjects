using System;
using System.Collections.Generic; 

namespace _07a_SalesReport
{
    public class SalesReport
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var result = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                string[] saleAttributes = Console.ReadLine().Split(' ');                 
                string town = saleAttributes[0];
                decimal price = decimal.Parse(saleAttributes[2]);
                decimal quantity = decimal.Parse(saleAttributes[3]);

                if (!result.ContainsKey(town))
                {
                    result[town] = 0;
                }

                result[town] += price * quantity;
            }

            foreach (var pair in result)
            {
                Console.WriteLine("{0} -> {1:f2}", pair.Key, pair.Value);
            }
        }
    }
}
