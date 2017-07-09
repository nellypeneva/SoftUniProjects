using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _08a_Mines
{
    class Mines
    {
        static void Main(string[] args)
        {

            string pattern = @"<([a-zA-Z]{2})>";
            string input = Console.ReadLine();
            Regex r = new Regex(pattern);
            MatchCollection matches = r.Matches(input);
            StringBuilder sb = new StringBuilder(input);

            foreach (Match m in matches)
            {
                string letters = m.Groups[1].Value;
                int length = Math.Abs((int)letters[0] - (int)letters[1]);

                string pattern2 = @"([^<>]{0," + length + "})" + m.Groups[0].Value + "([^<>]{0," + length + "})";
 
                Match match = Regex.Match(input, pattern2);
                int leftLength = match.Groups[1].Length;
                int rightLength = match.Groups[2].Length;

                input = Regex.Replace(input, pattern2,  new String('_', leftLength + rightLength + 4) );
            }

            Console.WriteLine(input);
        }
    }
}
