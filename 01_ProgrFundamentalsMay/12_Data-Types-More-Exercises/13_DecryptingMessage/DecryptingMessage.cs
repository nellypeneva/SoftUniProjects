using System; 

namespace _13_DecryptingMessage
{
    public class DecryptingMessage
    {
        public static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string message = String.Empty;

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                char resultLetter = (char)(letter + key);
                message = String.Concat(message, resultLetter);
            }

            Console.WriteLine(message);
        }
    }
}
