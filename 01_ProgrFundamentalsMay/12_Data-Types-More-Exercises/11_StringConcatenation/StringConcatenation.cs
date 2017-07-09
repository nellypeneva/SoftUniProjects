using System; 

namespace _11_StringConcatenation
{
    public class StringConcatenation
    {
        public static void Main()
        {
            char delimiter = char.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int remainder = 0;

            if (type == "odd")
            {
                remainder = 1;
            }

            int n = int.Parse(Console.ReadLine());
            string result = String.Empty;

            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();

                if (i % 2 == remainder)
                {
                    result = string.Concat(result, word, delimiter);
                }
            }

            Console.WriteLine(result.Remove(result.Length - 1));
        }
    }
}
