using System;

namespace _12_MasterNumbers
{
    public class MasterNumbers
    {
        public static void Main()
        {
            int range = int.Parse(Console.ReadLine());
            for (int num = 1; num <= range; num++)
            {
                if (IsPalindrome(num.ToString()) && SumOfDigits(num) && EvenDigitCheck(num))
                {
                    Console.WriteLine(num);
                }
            } 
        }

        public static bool IsPalindrome(string n)
        {
            for (int i = 0; i < n.Length / 2; i++)
            {
                if (n[i] != n[n.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool SumOfDigits(long num)
        {
            long sum = 0;
            while (num > 0)
            {
                var digit = num % 10;
                num /= 10;
                sum += digit;
            }

            if (0 == sum % 7)
            {
                return true;
            }

            return false;
        } 

        public static bool EvenDigitCheck(long num)
        {
            while (num > 0)
            {
                var digit = num % 10;

                if (digit % 2 == 0)
                {
                    return true;
                }

                num /= 10;
            }

            return false;
        }
    }
}