using System;
using System.Collections.Generic;
using System.Linq; 

namespace _05_ShortWordsSorted
{
    public class ShortWordsSorted
    {
        public static void Main()
        {

            char[] separators = {'.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?',' '};

            var words = Console.ReadLine()
                    .ToLower()
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                    .Distinct()
                    .Where(w => w.Length < 5)
                    .OrderBy(w => w)
                    .ToArray();

            Console.WriteLine(String.Join(", ", words));
        }
    }
}
