using System;
using System.Collections.Generic;
using System.Linq; 

namespace _04_Largest3Numbers
{
    public class Largest3Numbers
    {
        public static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var result = numbers.OrderByDescending(num => num).Take(3).ToArray();
            Console.WriteLine(String.Join(" ", result)); 
        }
    }
}
 