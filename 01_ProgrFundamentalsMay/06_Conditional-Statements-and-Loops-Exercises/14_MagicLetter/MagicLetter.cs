using System; 

namespace _14_MagicLetter
{
    class MagicLetter
    {
        static void Main()
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine()); 

            for (char i = firstLetter; i <= secondLetter; i++)  
            {
                if (i == thirdLetter) continue; 

                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    if (j == thirdLetter) continue; 

                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        if (k == thirdLetter) continue; 

                        Console.Write("{0}{1}{2} ", i, j, k);
                    }  
                }
            }

            Console.WriteLine();

        }
    }
}
