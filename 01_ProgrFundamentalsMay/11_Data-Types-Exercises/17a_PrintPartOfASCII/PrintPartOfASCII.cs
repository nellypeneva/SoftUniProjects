using System; 

namespace _17a_PrintPartOfASCII
{
    class PrintPartOfASCII
    {
        static void Main()
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            for (char ch = (char) startIndex; ch <= endIndex; ch++)
            {
                Console.Write(ch+" ");
            }

            Console.WriteLine();
        }
    }
}
