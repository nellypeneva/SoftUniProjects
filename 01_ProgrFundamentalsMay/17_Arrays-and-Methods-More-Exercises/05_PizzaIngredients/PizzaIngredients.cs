using System;
using System.Collections.Generic;
using System.Linq; 

namespace _05_PizzaIngredients
{
    public class PizzaIngredients
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            byte n = byte.Parse(Console.ReadLine());
            byte counter = 0;
            List<string> ingredients = new List<string>();

            foreach (var item in input)
            {
                if (item.Length == n)
                {
                    counter++;
                    Console.WriteLine("Adding {0}.", item);
                    ingredients.Add(item);

                    if (counter == 10)
                    {
                        break;
                    }
                } 
            } 

            Console.WriteLine("Made pizza with total of {0} ingredients.", counter);
            Console.WriteLine("The ingredients are: {0}.", String.Join(", ", ingredients)); 
        }
    }
}
