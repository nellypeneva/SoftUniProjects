using System;
using System.Collections.Generic;
using System.Linq; 

namespace _02_AppendLists
{
    public class AppendLists
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
            List<int> numbers = new List<int>();
            char[] separators = { ' ' };

            for (int i = input.Count - 1; i >= 0; i--)
            {
                string current = input[i].Trim();
                List<int> item = current.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                numbers.AddRange(item);
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}