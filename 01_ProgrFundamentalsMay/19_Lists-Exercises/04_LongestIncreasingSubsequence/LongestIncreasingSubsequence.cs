using System;
using System.Collections.Generic;
using System.Linq; 

namespace _04_LongestIncreasingSubsequence
{
    public class LongestIncreasingSubsequence
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] length = new int[input.Length];
            int[] prev = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                length[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (input[j] < input[i] && length[j] >= length[i])
                    {
                        length[i]++;
                        prev[i] = j;
                    }
                }
            }

            int maxValue = length.Max();
            int index = length.ToList().IndexOf(maxValue);

            List<int> sequence = new List<int>();

            while (index >= 0)
            {
                sequence.Add(input[index]);
                index = prev[index];
            }

            sequence.Reverse();
            Console.WriteLine(String.Join(" ", sequence));
        }
    }
}
