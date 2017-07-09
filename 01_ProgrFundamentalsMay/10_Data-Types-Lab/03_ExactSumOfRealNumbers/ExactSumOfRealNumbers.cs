﻿using System; 

namespace _03_ExactSumOfRealNumbers
{
    public class ExactSumOfRealNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
