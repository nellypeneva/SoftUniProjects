using System;
using System.Linq;

namespace _02_RotateAndSum
{
    public class RotateAndSum
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());

            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            int[] numbersSum = new int[numbers.Length];

            for (int i = 1; i <= k; i++)
            {
                rotateRight(numbers);

                for (int j = 0; j < numbers.Length; j++)
                {
                    numbersSum[j] += numbers[j];
                }
            }

            Console.WriteLine(String.Join(" ", numbersSum));
        }

        public static void rotateRight(int[] arr)
        {
            int lastNum = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = lastNum;
        }

    }
}