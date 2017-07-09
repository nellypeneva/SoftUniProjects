using System; 

namespace _06_TriplesOfLatinLetters
{
    public class TriplesOfLatinLetters
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                char firstLetter = (char)('a' + i);

                for (int j = 0; j < n; j++)
                {
                    char secondLetter = (char)('a' + j);

                    for (int k = 0; k < n; k++)
                    {
                        char thirdLetter = (char)('a' + k);
                        Console.WriteLine("{0}{1}{2}", firstLetter, secondLetter, thirdLetter);
                    }
                }
            }
        }
    }
}
