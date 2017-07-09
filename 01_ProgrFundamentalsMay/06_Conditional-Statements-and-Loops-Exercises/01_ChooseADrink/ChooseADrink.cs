using System; 

namespace _01_ChooseADrink
{
    class ChooseADrink
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            string drink = "Tea";

            switch (profession)
            {
                case "Athlete": { drink = "Water"; break; }
                case "Businessman":
                case "Businesswoman": { drink = "Coffee"; break; }
                case "SoftUni Student": { drink = "Beer"; break; }
                default: { drink = "Tea"; break; }
            }

            Console.WriteLine(drink);
        }
    }
}
