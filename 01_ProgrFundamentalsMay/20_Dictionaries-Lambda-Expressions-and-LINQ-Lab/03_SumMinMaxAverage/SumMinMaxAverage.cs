using System;
using System.Collections.Generic;
using System.Linq; 

namespace _03_SumMinMaxAverage
{
    public class SumMinMaxAverage
    {
        public static void Main()
        {
            //int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());  
            }

            Console.WriteLine("Sum = {0}", numbers.Sum());
            Console.WriteLine("Min = {0}", numbers.Min());
            Console.WriteLine("Max = {0}", numbers.Max());
            Console.WriteLine("Average = {0}", numbers.Average()); 
        }
    }
}
