using System;
using System.Linq;

namespace _07_SumArrays
{
    public class SumArrays
    {
        public static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            int[] intArray1 = input1.Split(' ').Select(int.Parse).ToArray();
            int[] intArray2 = input2.Split(' ').Select(int.Parse).ToArray();

            int length = Math.Max(intArray1.Length, intArray2.Length);
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = intArray1[i % intArray1.Length] + intArray2[i % intArray2.Length];
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}