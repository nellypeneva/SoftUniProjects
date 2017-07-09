using System;
using System.Text.RegularExpressions; 

namespace _06_ReplaceTag
{
    public class ReplaceTag
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"<a.*href=(""|')(.*)\1>(.*?)<\/a>";   //string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
            string replace = @"[URL href=$1$2$1]$3[/URL]";          //string replace = @"[URL href=$1]$2[/URL]"; 
            
            Regex regex = new Regex(pattern);

            while (input != "end")
            {
                string result = regex.Replace(input, replace);     //string result = Regex.Replace(input, pattern, replace);
                Console.WriteLine(result);
                input = Console.ReadLine();
            } 
        }
    }
}
