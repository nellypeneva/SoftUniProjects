using System;
using System.Collections.Generic;
using System.Linq; 

namespace _06_FoldAndSum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = numbers.Length / 4;

            var selection1 = numbers.Take(k).Reverse();
            var selection2 = numbers.Skip(3 * k).Take(k).Reverse();
            
            var row1 = selection1.Concat(selection2).ToArray();
            var row2 = numbers.Skip(k).Take(2*k).ToArray();

            var sum = row1.Select((x, index) => x + row2[index]); 

            Console.WriteLine(String.Join(" ", sum)); 
        }
    }
}
