﻿using System; 

namespace _10_SumOfChars
{
    public class SumOfChars
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum=0;

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sum += (int)letter;
            }

            Console.WriteLine("The sum equals: {0}", sum);
        }
    }
}
 