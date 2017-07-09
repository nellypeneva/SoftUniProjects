using System; 
using System.Text.RegularExpressions;
using System.Text;

namespace _04_CubicMessages
{
    public class CubicMessages
    {
        public static void Main()
        {
            //string pattern = @"^(\d+)([A-Za-z]+)([^A-Za-z]*)$"; 

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Over!")
                {
                    break;
                }

                int n = int.Parse(Console.ReadLine());
                string pattern =  @"^(\d+)([A-Za-z]{"+n+"})([^A-Za-z]*)$" ;
              
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string message = match.Groups[2].Value;
                    string indexesString = match.Groups[1].Value + match.Groups[3].Value; 

                    Console.WriteLine("{0} == {1}", message, StringFromIndexNums(message, indexesString));
                }
            }
        }

        private static string StringFromIndexNums(string s, string indexesString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char symbol in indexesString)
            {
                if (char.IsDigit(symbol))
                {
                    int currentIndex = int.Parse(symbol.ToString());
                    if (currentIndex >= 0 && currentIndex < s.Length)
                    {
                        sb.Append(s[currentIndex]);
                    }
                    else
                    {
                        sb.Append(' ');
                    }
                }
            }

            return sb.ToString();
        }
    }
} 