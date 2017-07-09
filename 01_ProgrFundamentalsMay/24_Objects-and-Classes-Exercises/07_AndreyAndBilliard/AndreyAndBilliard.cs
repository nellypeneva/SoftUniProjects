using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_AndreyAndBilliard
{
    class AndreyAndBilliard
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> productsList = createPriceList( n); 

            List<Customer> allCustomers = new List<Customer>();

            string cmd = Console.ReadLine();

            while (cmd != "end of clients") 
            {
               // string[] input = cmd.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string[] input = cmd.Split( '-', ','  );
                                
                string custName = input[0];
                string product = input[1];

                if (!productsList.ContainsKey(product))
                {
                    cmd = Console.ReadLine();
                    continue;
                }

                int qty = int.Parse(input[2]); 

                if (allCustomers.Any(c => c.Name == custName))
                {
                    Customer currentCustomer = allCustomers.First(c => c.Name == custName); 

                    if (!currentCustomer.shopList.ContainsKey(product))
                    {
                        currentCustomer.shopList[product] = 0;
                    }

                    currentCustomer.shopList[product] += qty;
                }
                else
                {
                    Customer customer = new Customer(custName);
                    customer.shopList.Add(product, qty);
                    allCustomers.Add(customer);
                }

                cmd = Console.ReadLine(); 
            }

            printResults(allCustomers, productsList);
        }


        private static Dictionary<string, decimal> createPriceList(int n)
        {
             Dictionary<string, decimal> productsList = new Dictionary<string, decimal>();

             for (int i = 0; i < n; i++)
             {
                 string[] line = Console.ReadLine().Split('-');
                 string product = line[0];
                 decimal price = decimal.Parse(line[1]);

                 //if (!productsList.ContainsKey(product))
                 //{
                 //    productsList.Add(product, 0);
                 //}

                 productsList[product] = price;
             }

             return productsList;
        }

        private static void printResults(List<Customer> allCustomers, Dictionary<string, decimal> productsList)
        {
            decimal billTotal = 0;
            allCustomers = allCustomers.OrderBy(x => x.Name).ToList();

            foreach (var customer in allCustomers)
            {
                Console.WriteLine(customer.Name);
                decimal bill = 0;

                foreach (var item in customer.shopList)
                {
                    if (!productsList.ContainsKey(item.Key))
                    {
                        continue;
                    }

                    bill += item.Value * productsList[item.Key];
                    Console.WriteLine("-- {0} - {1}", item.Key, item.Value);
                }

                Console.WriteLine("Bill: {0:f2}", bill);

                billTotal += bill;
            }

            Console.WriteLine("Total bill: {0:f2}", billTotal);
        }
    }
}
