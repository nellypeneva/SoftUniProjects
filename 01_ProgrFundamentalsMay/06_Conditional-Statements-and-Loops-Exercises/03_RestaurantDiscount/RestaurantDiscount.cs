using System; 

namespace _03_RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main()
        {
            int numPeople= int.Parse(Console.ReadLine());
            string servicePackage = Console.ReadLine();

            if (numPeople > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            int packagePrice; 
            double discount;  
             
            switch (servicePackage)
            {
                case "Normal": { discount = 0.95; packagePrice = 500; break; }
                case "Gold": { discount = 0.90; packagePrice = 750; break; }
                case "Platinum": { discount = 0.85; packagePrice = 1000; break; }
                default: { discount = 1; packagePrice = 0; break; }
            }
 
            if (numPeople <=50)
            {
                double price = (2500 + packagePrice) * discount;
                Console.WriteLine("We can offer you the Small Hall");
                Console.WriteLine("The price per person is {0:f2}$", price / numPeople); 
            }
            else if (numPeople <= 75)
            {
                double price = (5000 + packagePrice) * discount;
                Console.WriteLine("We can offer you the Terrace");
                Console.WriteLine("The price per person is {0:f2}$", price / numPeople); 
            }
            else if (numPeople <= 120)
            {
                double price = (7500 + packagePrice) * discount;
                Console.WriteLine("We can offer you the Great Hall");
                Console.WriteLine("The price per person is {0:f2}$", price / numPeople); 
            }

        }
    }
}
