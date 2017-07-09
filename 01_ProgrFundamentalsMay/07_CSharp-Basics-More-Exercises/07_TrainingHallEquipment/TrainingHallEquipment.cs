using System; 

namespace _07_TrainingHallEquipment
{
    class TrainingHallEquipment
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int numItems = int.Parse(Console.ReadLine());
            double total = 0;

            for (int i = 0; i < numItems; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());

                if (count>1)
                {
                    name += "s";
                }

                double itemPriceTotal = count * price;
                Console.WriteLine("Adding {0} {1} to cart.", count, name);

                if (budget >= itemPriceTotal)
                {
                    budget -= itemPriceTotal;
                    total += itemPriceTotal; 
                }
                else
                {
                    Console.WriteLine("Subtotal: ${0:f2}", total + itemPriceTotal); 
                    Console.WriteLine("Not enough. We need ${0:f2} more.", Math.Abs(budget - itemPriceTotal));                    
                    return;
                }
            }

            Console.WriteLine("Subtotal: ${0:f2}", total);
            Console.WriteLine("Money left: ${0:f2}", budget);
        }
    }
}
