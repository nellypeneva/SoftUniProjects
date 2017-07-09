using System;
using System.Collections.Generic; 

namespace _07_SalesReport
{
    public class SalesReport
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Sale> sales = new List<Sale>();

            for (int i = 0; i < n; i++)
            {
                string[] saleAttributes = Console.ReadLine().Split(' ');

                Sale currentSale = new Sale
                {
                    Town = saleAttributes[0],
                    Product = saleAttributes[1],
                    Price = decimal.Parse(saleAttributes[2]),
                    Quantity = decimal.Parse(saleAttributes[3])
                };

                sales.Add(currentSale);
            }

            var result = new SortedDictionary<string, decimal>();

            foreach (var sale in sales)
            {
                if (!result.ContainsKey(sale.Town))
                {
                    result[sale.Town] = 0;
                }

                result[sale.Town] += sale.Price * sale.Quantity;
            }

            foreach (var pair in result)
            {
                Console.WriteLine("{0} -> {1:f2}", pair.Key, pair.Value);
            }
        }
    }
}
