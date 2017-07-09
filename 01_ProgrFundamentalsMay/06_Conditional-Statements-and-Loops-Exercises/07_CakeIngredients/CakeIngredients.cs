using System; 

namespace _07_CakeIngredients
{
    class CakeIngredients
    {
        static void Main()
        {
            int counter = 0;
            string input = Console.ReadLine();

            while (input != "Bake!")
            {
                counter++;
                Console.WriteLine("Adding ingredient {0}.", input);
                input = Console.ReadLine();
            }

            Console.WriteLine("Preparing cake with {0} ingredients.", counter);
        }
    }
}
