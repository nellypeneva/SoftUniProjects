using System; 

namespace _05_SpecialNumbers
{
    class Elevator
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int currentNumber = i;
                int sumDigits = 0;

                while (currentNumber > 0) 
                {
                    int remainder;
                    currentNumber = Math.DivRem(currentNumber, 10, out remainder);
                    sumDigits += remainder;
                }

                bool isSpecial = (sumDigits == 5) || (sumDigits == 7) || (sumDigits == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecial); 
            }
        }
    }
}
