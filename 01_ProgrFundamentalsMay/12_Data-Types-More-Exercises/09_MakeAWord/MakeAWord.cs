using System;
using System.Text; 

namespace _09_MakeAWord
{
    public class MakeAWord
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                builder.Append(ch);
            }

            Console.WriteLine("The word is: {0}", builder.ToString());
        }
    }
}
