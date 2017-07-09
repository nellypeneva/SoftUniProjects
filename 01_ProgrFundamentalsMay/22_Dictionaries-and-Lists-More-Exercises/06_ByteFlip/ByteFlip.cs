using System;
using System.Collections.Generic;
using System.Linq; 

namespace _06_ByteFlip
{
    public class ByteFlip
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            var result = input.Where(x => x.Length == 2)
                        .Select(x => new string(x.ToCharArray().Reverse().ToArray()))
                        .Reverse()
                        .Select(x => (char) Convert.ToInt32(x, 16)) ;

            Console.WriteLine(String.Join("", result)); 
        }
    }
}
