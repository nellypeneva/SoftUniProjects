using System; 

namespace _09_MelrahShake
{
    public class MelrahShake
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            if (pattern.Length == 0)
            {
                Console.WriteLine("No shake.");
                Console.WriteLine(input);
                return;
            } 

            while (true)
            {
                int first = input.IndexOf(pattern);
                int last = input.LastIndexOf(pattern);

                if (first > -1 && last > -1 && pattern.Length > 0 && first <= last - pattern.Length)  
                {
                    input = input.Remove(last, pattern.Length);
                    input = input.Remove(first, pattern.Length);
                    Console.WriteLine("Shaked it."); 
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake."); 
                    break;
                }
            }
 
            Console.WriteLine(input);
        }
    }
}

 