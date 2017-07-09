using System;
using System.Collections.Generic;
using System.Linq; 

namespace _01_CountRealNumbers
{
    public class CountRealNumbers
    {
        public static void Main()
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            SortedDictionary<double, int>  numCount = new SortedDictionary<double, int> ();

            foreach (var num in input)
            {
                if (!numCount.ContainsKey(num))
                {
                    numCount[num] = 0;
                }

                numCount[num]++;
            } 

            foreach (var item in numCount)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
