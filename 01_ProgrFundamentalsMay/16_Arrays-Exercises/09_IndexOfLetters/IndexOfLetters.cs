using System;
using System.Linq;

namespace _09_IndexOfLetters
{
    public class IndexOfLetters
    {
        public static void Main()
        {
            char[] input = Console.ReadLine().ToLower().ToArray();
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                int index = Array.IndexOf(alphabet, input[i]);
                Console.WriteLine("{0} -> {1}", input[i], index);
            }
        }
    }
}