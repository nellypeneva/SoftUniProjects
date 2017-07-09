using System; 
using System.Text.RegularExpressions;
using System.Text;
using System.Linq; 
namespace _03_RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([^\d]+)(\d+)";   
            MatchCollection matches = Regex.Matches(input, pattern);
            StringBuilder result = new StringBuilder();
            foreach (Match match in matches)
            {
                string text=  match.Groups[1].Value.ToUpper();
                int num = int.Parse(match.Groups[2].Value);
                result.Append(string.Join("", Enumerable.Repeat(text, num)));
            }

            Console.WriteLine("Unique symbols used: {0}", result.ToString().Distinct().Count());
            Console.WriteLine(result.ToString());
        } 
    }
}
 
