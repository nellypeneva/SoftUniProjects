using System;
using System.Globalization; 

namespace _01_SoftUniCoffeeOrders
{
    public class SoftUniCoffeeOrders
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Decimal totalPrice = 0;

            for (int i = 0; i < n; i++)
            {
                Decimal price = Decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int capsulesCount = int.Parse(Console.ReadLine());
 
                int days = DateTime.DaysInMonth(date.Year, date.Month);
                Decimal itemPrice = days * price * capsulesCount;
                totalPrice += itemPrice;
                Console.WriteLine("The price for the coffee is: ${0:f2}", itemPrice);
            }

            Console.WriteLine("Total: ${0:f2}", totalPrice);
        }
    }
}
