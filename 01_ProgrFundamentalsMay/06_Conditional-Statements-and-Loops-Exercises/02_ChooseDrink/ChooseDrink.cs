using System;

namespace _02_ChooseDrink
{
    class ChooseDrink
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            string drink = "Tea";

            switch (profession)
            {
                case "Athlete": { drink = "Water"; break; }
                case "Businessman":
                case "Businesswoman": { drink = "Coffee"; break; }
                case "SoftUni Student": { drink = "Beer"; break; }
                default: { drink = "Tea"; break; }
            }

            double price = 1.2;

            switch (drink)
            {
                case "Water": { price = 0.7; break; }
                case "Coffee": { price = 1.0; break; }
                case "Beer": { price = 1.7; break; }
                default: { price = 1.2; break; }
            }

            Console.WriteLine("The {0} has to pay {1:f2}.", profession, price * quantity);
        }
    }
}
