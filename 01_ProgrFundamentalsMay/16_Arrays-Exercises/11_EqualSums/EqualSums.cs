using System;
using System.Linq;

namespace _11_EqualSums
{
    public class EqualSums
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool found = false;

            for (int i = 0; i < input.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;

                for (int j = i - 1; j >= 0; j--)
                {
                    sumLeft += input[j];
                }

                for (int j = i + 1; j < input.Length; j++)
                {
                    sumRight += input[j];
                }

                if (sumLeft == sumRight)
                {
                    found = true;
                    Console.WriteLine(i);
                }
            }

            if (!found)
            {
                Console.WriteLine("no");
            }
        }
    }
}