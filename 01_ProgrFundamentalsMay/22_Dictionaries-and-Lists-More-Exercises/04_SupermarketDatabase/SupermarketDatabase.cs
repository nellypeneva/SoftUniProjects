using System;
using System.Collections.Generic;
using System.Linq; 

namespace _04_SupermarketDatabase
{
    public class SupermarketDatabase
    {
        public static void Main()
        {
            Dictionary<string, ProductItem> products = new Dictionary<string, ProductItem>();
            string input = Console.ReadLine();
           
            while (input!="stocked")
            {
                string[] arr = input.Split(' ');
                string name = arr[0];
                double price = double.Parse(arr[1]);
                int qty = int.Parse(arr[2]);

                if (!products.ContainsKey(name))
                {
                    products[name] = new ProductItem(name, price, 0);
                } 

                products[name].Price = price;
                products[name].Qty += qty;

                input = Console.ReadLine();
            }  

            double total = 0;

            foreach (var product in products)
            {
                ProductItem productItem = product.Value;
                double productPrice = productItem.Qty * productItem.Price;
                total += productPrice;
                Console.WriteLine("{0}: ${1:f2} * {2} = ${3:f2}", productItem.Name, productItem.Price, productItem.Qty, productPrice);
            }

            Console.WriteLine(new String('-',30));
            Console.WriteLine("Grand Total: ${0:f2}", total);
        }
    }

    // placed here because for this task i can not upload solution 
    class ProductItem
    {
        public ProductItem(string name, double price, int qty)
        {
            this.Name = name;
            this.Price = price;
            this.Qty = qty;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
    }
}