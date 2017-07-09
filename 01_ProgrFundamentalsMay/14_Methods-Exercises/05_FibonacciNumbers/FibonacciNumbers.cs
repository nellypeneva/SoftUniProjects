using System;

namespace _05_FibonacciNumbers
{
    public class FibonacciNumbers
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciNumber(num));
        }

        //1,1,2,3,5,8,13,21,34,55,89,144
        public static long FibonacciNumber(int n)
        {
            if (n <= 1)
                return 1;

            return FibonacciNumber(n - 1) + FibonacciNumber(n - 2);
        }
    }
}
