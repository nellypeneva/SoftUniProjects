using System; 

namespace _13_GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            long magicNumber = long.Parse(Console.ReadLine());
            string combination = String.Empty;
            int counter = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    counter++;

                    if (i + j == magicNumber)
                    {
                        combination = i + " + " + j + " = " + magicNumber;
                    }
                }
            }

            if(combination!=String.Empty)
            {
                Console.WriteLine("Number found! {0}", combination);
            }
            else
            {
                Console.WriteLine("{0} combinations - neither equals {1}", counter, magicNumber);
            }
        }
    }
}
