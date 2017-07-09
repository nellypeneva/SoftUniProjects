using System;
using System.Collections.Generic;
using System.Linq; 

namespace _02_OddFilter
{
    public class OddFilter
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] evenNums = arr.Where(x => x % 2 == 0).ToArray();
            double avg = evenNums.Average();
            var result = evenNums.Select(x => (x > avg) ? (x + 1) : (x - 1));
            Console.WriteLine(String.Join(" ", result));            
        }
    }
}
