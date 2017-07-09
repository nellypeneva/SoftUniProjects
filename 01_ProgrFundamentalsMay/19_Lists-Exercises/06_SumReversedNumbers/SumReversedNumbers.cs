using System;
using System.Collections.Generic;
using System.Linq; 

namespace _06_SumReversedNumbers
{
    public class SumReversedNumbers
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            if (input.Count > 0)
            {
                long sum = 0;

                foreach (var number in input)
                {
                    sum += ReverseNumber(number);
                }

                Console.WriteLine(sum);
            }
        }

        public static long ReverseNumber(int num)
        {
            long reversedNum = 0;

            while (num > 0)
            {
                reversedNum = reversedNum * 10 + num % 10;
                num /= 10;
            }

            return reversedNum;
        }
    }
}
