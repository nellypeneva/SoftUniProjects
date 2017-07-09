using System; 

namespace _02_NumberChecker
{
    class NumberChecker
    {
        static void Main()
        {
            string input = Console.ReadLine() ;
            long number;
            bool result = long.TryParse(input, out number);

            if (result)
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
