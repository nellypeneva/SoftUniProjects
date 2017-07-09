using System;

namespace _06_PrimeChecker
{
    public class PrimeChecker
    {
        public static void Main()
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(num));
        }
        public static bool IsPrime(long number)
        {
            bool prime = false;
            var boundary = (int)Math.Ceiling(Math.Sqrt(number));
            if (number > 1)
            {
                prime = true;

                if (number == 2) return true;

                for (int i = 2; i <= boundary; i++)
                {
                    if (0 == number % i)
                    {
                        prime = false;
                        break;
                    }
                }
            }

            return prime;
        }
    }
}
