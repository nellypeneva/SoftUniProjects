using System;
using System.Globalization;
using System.Linq; 

namespace _01_SortTimes
{
    public class SortTimes
    {
        public static void Main()
        {
            TimeSpan[] arr = Console.ReadLine().Split(' ').Select(x=> TimeSpan.ParseExact(x, @"hh\:mm", CultureInfo.InvariantCulture)).ToArray();
            Array.Sort(arr);
            var result = arr.Select(x => x.ToString(@"hh\:mm")).ToArray(); 
            Console.WriteLine(String.Join(", ", result));
        }
    }
}
