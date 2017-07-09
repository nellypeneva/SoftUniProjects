using System;
using System.Linq;

namespace _03_FoldAndSum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int[] inputNumbers = input.Split(' ').Select(int.Parse).ToArray();

            int k = inputNumbers.Length / 4;
            int[] nums = new int[2 * k];

            int index = 0;

            for (int i = k - 1; i >= 0; i--)
            {
                nums[index] = inputNumbers[i];
                index++;
            }

            for (int i = 4 * k - 1; i >= 3 * k; i--)
            {
                nums[index] = inputNumbers[i];
                index++;
            }

            index = 0;

            for (int i = k; i < 3 * k; i++)
            {
                nums[index] += inputNumbers[i];
                index++;
            }

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}