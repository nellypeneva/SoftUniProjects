using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO; 
namespace _08_UseYourChainsBuddy
{
    public class UseYourChainsBuddy
    {
        public static void Main()
        {
            string pattern = @"<p>(.*?)<\/p>";
            //string pattern = @"<p>[\s]?(.*?)[\s]?</p>";
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            string input = Console.ReadLine();
         
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            StringBuilder sb = new StringBuilder();

            foreach (Match match in matches)
            {
                string text = match.Groups[1].Value; 

                text = Regex.Replace(text, @"[^a-z0-9]+", " ");
                text = Regex.Replace(text, @"\s{2,}", " ");
                text = DecryptText(text); 
                sb.Append(text);
            }

            Console.WriteLine(sb.ToString()); 
        }

        public static string DecryptText(string word)
        {
            StringBuilder b = new StringBuilder(); 

            foreach (char symbol in word)
            {
                char letter = symbol;

                if (letter >= 'a' && letter <= 'm') 
                {
                    letter = (char)(letter + 13);
                }
                else if (letter >= 'n' && letter <= 'z')
                {
                    letter = (char)(letter - 13);
                } 

                b.Append(letter); 
            }

            return b.ToString();
        }
    } 
}