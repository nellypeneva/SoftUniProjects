using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_SortNumbers
{
    public class SortNumbers
    {
        public static void Main()
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            input.Sort();
            Console.WriteLine(String.Join(" <= ", input));
        }
    }
}