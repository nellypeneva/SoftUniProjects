using System;
using System.Numerics;
 
namespace _02_BaseNToBase10
{
    public class BaseNToBase10
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int fromBase = int.Parse(input[0]);
            string number = input[1] ;
            BigInteger result = 0;
            int power = 0;

            for (int i = number.Length-1; i >=0 ; i--)
            {
                BigInteger num = BigInteger.Parse(number[i].ToString());
                result += num * BigInteger.Pow(fromBase, power);
                power++;
            }

            Console.WriteLine(result);
        }
    }
}
