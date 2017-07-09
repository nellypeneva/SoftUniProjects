using System;
using System.Collections.Generic;
using System.Linq; 

namespace _04_GrabAndGo
{
    public class GrabAndGo
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); 
            int n = int.Parse(Console.ReadLine());
            int index = Array.LastIndexOf(input, n);

            if (index < 0) 
            {
                Console.WriteLine("No occurrences were found!");
                return;
            }

            long sum = 0;

            for (int i = 0; i < index; i++)
            {
                sum += input[i];
            } 
            
            Console.WriteLine(sum);
        }
    }
}
