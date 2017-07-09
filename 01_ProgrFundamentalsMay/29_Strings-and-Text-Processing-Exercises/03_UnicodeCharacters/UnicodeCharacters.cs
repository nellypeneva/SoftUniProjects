using System; 
using System.Text; 

namespace _03_UnicodeCharacters
{
    public class UnicodeCharacters
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string result = String.Empty;

            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)c));  // ((int)c).ToString("X4")
            }

            Console.WriteLine(sb);
        } 
    }
}
 