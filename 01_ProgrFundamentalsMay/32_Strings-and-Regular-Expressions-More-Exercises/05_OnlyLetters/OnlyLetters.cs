using System; 
using System.Text.RegularExpressions;
namespace _05_OnlyLetters
{
    class OnlyLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(\d+)([a-zA-z])"; 
            Regex r = new Regex(pattern);
            MatchCollection matches = r.Matches(input); 

            foreach (Match m in matches)
            {
                string num = String.Format(@"" + m.Groups[1].Value);
                string letter = String.Format(@"" + m.Groups[2].Value);    
                
                //input = Regex.Replace(input, num, letter); 
                Regex rgx = new Regex(num);
                input = rgx.Replace(input, letter, 1); 
            }

            Console.WriteLine(input);
        }
    }
}
 