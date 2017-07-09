using System;
using System.Linq;

namespace _02_ReverseArray
{
    public class ReverseArray
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //for (int i = numbers.Length - 1; i>=0 ; i--)
            //{
            //    Console.Write("{0} ", numbers[i]);
            //}
            //Console.WriteLine();

            Console.WriteLine(String.Join(" ", numbers.Reverse()));
        }
    }
}