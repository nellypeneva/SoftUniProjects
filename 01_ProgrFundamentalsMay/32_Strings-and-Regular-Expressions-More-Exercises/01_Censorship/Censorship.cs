using System;
using System.Text.RegularExpressions;

namespace _01_Censorship
{
    public class Censorship
    {
        public static void Main()
        {

            string word = Console.ReadLine();
            string input = Console.ReadLine();

            string replace =  new String('*', word.Length);
            //word = String.Format(@"\b"+word+@"\b");
            word = String.Format(@"" + word);
            string text = Regex.Replace(input, word, replace);
            Console.WriteLine(text);
        }
    }
}
