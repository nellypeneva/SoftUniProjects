using System;
using System.Text;
using System.Text.RegularExpressions;
namespace _08_Mines
{
    class Mines
    {
        static void Main()
        {
            string pattern = @"<([a-zA-Z]{2})>";
            string input = Console.ReadLine();
            Regex r = new Regex(pattern);
            MatchCollection matches = r.Matches(input);
            StringBuilder sb = new StringBuilder(input);

            foreach (Match m in matches)
            {
                string letters = m.Groups[1].Value;               
                int length =  Math.Abs((int)letters[0] - (int)letters[1]); 
               
                int pos = 2 * length + 4;
 
                int startIndex = m.Index - length;

                if (startIndex < 0)
                {
                    pos += startIndex;
                    startIndex = 0;
                }

                if (startIndex + pos >= input.Length)
                {
                    pos = input.Length - startIndex;
                }

                sb.Remove(startIndex, pos);
                sb.Insert(startIndex, new String('_', pos)); 
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
 


