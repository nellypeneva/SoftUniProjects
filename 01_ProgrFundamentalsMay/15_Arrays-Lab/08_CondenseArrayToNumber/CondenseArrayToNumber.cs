using System;
using System.Linq;

namespace _08_CondenseArrayToNumber
{
    public class CondenseArrayToNumber
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            while (numbers.Length > 1)
            {
                int[] condensed = new int[numbers.Length - 1];

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                }

                numbers = condensed;
            }

            Console.WriteLine(numbers[0]);
        }
    }
}