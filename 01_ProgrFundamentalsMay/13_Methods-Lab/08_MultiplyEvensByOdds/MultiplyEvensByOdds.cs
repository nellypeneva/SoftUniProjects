using System;

namespace _08_MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            num = Math.Abs(num);
            int sum = GetSumOfOddDigits(num) + GetSumOfEvenDigits(num);
            Console.WriteLine(sum);
        }

        public static int GetSumOfOddDigits(int num)
        {
            return GetSumOfDigits(num, 0);
        }
        public static int GetSumOfEvenDigits(int num)
        {
            return GetSumOfDigits(num, 1);
        }
        public static int GetSumOfDigits(int num, int remainder)
        {
            int result = 0;

            foreach (var symbol in num.ToString())
            {
                int digit = symbol - '0';

                if (remainder < 0 || remainder > 1)
                {
                    remainder = 0;
                }

                if (digit % 2 == remainder)
                {
                    result += digit;
                }
            }

            return result;
        }
    }
}

