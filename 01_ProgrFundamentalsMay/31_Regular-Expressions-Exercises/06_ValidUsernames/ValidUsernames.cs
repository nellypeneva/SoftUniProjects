using System; 
using System.Text.RegularExpressions; 

namespace _06_ValidUsernames
{
    public class ValidUsernames
    {
        public static void Main(string[] args)
        {
            string pattern = @"(?<=[\s/()\\]|^)([A-Za-z]\w{2,24})(?=[\s/()\\]|$)";
           
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
          
            int biggestSum = 0;
            int pos = 0;
            for (int i = 0; i < matches.Count - 1; i++)
            {
                int sum = matches[i].Length + matches[i+1].Length; 

                if (sum > biggestSum)
                {
                    biggestSum = sum;
                    pos = i; 
                }
            }

            Console.WriteLine(matches[pos]);
            Console.WriteLine(matches[pos+1]);
        }
    }
}

 
//string pattern = @"(?<=[\s\/\\(\)]|^)([A-Za-z]\w{2,24})(?=[\s\/\\(\)]|$)"; 