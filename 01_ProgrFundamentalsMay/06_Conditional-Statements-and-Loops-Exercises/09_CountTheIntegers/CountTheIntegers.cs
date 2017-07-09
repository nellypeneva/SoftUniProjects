using System; 

namespace _09_CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main()
        {
            int input;
            bool result = int.TryParse(Console.ReadLine(), out input);
            int counter = 0;

            while (result)
            { 
               counter++;
               result = int.TryParse(Console.ReadLine(), out input); 
            }

            Console.WriteLine(counter);
        }
    }
}
