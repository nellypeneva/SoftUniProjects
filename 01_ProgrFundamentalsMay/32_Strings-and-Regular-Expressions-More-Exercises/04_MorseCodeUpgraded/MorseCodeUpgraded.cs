using System; 
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04_MorseCodeUpgraded
{
    class MorseCodeUpgraded
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            string pattern = @"(0+)|(1+)";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            { 
                string line= input[i];
                int numZeros = line.Where(n => n == '0').Count();
                int numOnes = line.Where(n => n == '1').Count();

                int sum = numZeros * 3 + numOnes * 5; 

                Regex r = new Regex(pattern);
                MatchCollection matches = r.Matches(line);
                
                foreach (Match m in matches)
                {
                    sum += (m.Groups[1].Value.Length > 1) ? m.Groups[1].Value.Length : 0;
                    sum += (m.Groups[2].Value.Length > 1) ? m.Groups[2].Value.Length : 0;
                }

                sb.Append((char) sum);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
