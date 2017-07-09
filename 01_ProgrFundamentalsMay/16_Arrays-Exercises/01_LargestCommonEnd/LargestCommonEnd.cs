using System;
using System.Linq;

namespace _01_LargestCommonEnd
{
    public class LargestCommonEnd
    {
        public static void Main()
        {
            string[] input1 = Console.ReadLine().Split(' ').ToArray();
            string[] input2 = Console.ReadLine().Split(' ').ToArray();

            int minLength = Math.Min(input1.Length, input2.Length);

            int maxCountLeft = 0;
            int maxCountRight = 0;

            for (int i = 0; i < minLength; i++)
            {
                if (input1[i] == input2[i])
                {
                    maxCountLeft++;
                }

                if (input1[input1.Length - 1 - i] == input2[input2.Length - 1 - i])
                {
                    maxCountRight++;
                }
            }

            Console.WriteLine(Math.Max(maxCountLeft, maxCountRight));
        }
    }
}