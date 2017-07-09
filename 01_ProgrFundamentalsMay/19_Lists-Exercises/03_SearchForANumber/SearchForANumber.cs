using System;
using System.Collections.Generic;
using System.Linq; 

namespace _03_SearchForANumber
{
    public class SearchForANumber
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            input = input.Take(arr[0]).ToList();
            input.RemoveRange(0, arr[1]);

            string result = (input.Contains(arr[2])) ? "YES!" : "NO!";
            Console.WriteLine(result); 
        }
    }
}
