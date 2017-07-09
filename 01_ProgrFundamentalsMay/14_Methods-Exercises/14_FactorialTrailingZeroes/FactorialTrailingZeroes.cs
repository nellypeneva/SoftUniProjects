using System;
using System.Numerics;

namespace _14_FactorialTrailingZeroes
{

    public class FactorialTrailingZeroes
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = Factoriel(n);
            BigInteger count = CountTrailingZeros(factorial.ToString());
            Console.WriteLine(count);
        }

        public static BigInteger Factoriel(int num)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        } 

        public static BigInteger CountTrailingZeros(string input)
        {
            BigInteger count = 0;

            for (int i = input.Length - 1; i >= 0 && input[i] == '0'; i--)
            {
                count++;
            }

            return count;
        }
    }
}