using System; 

namespace _05_WordInPlural
{
    class WordInPlural
    {
        static void Main()
        {
            string word = Console.ReadLine();
            int lastIndex = word.Length - 1;
             
            if (word.EndsWith("y"))
            {
                Console.WriteLine("{0}ies", word.Remove(lastIndex));
            }
            else if ( word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") || 
                      word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z") )
            {
                Console.WriteLine("{0}es", word);
            }
            else
            {
                Console.WriteLine("{0}s", word);
            }
        }
    }
}
