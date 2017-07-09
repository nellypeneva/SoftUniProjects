using System; 

namespace _14_BoatSimulator
{
    public class BoatSimulator
    {
        public static void Main()
        {
            char firstBoatSymbol = char.Parse(Console.ReadLine());
            char secondBoatSymbol = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int firstBoatTiles = 0;
            int secondBoatTiles = 0;

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();

                if (input!="UPGRADE")
                {
                    if (i % 2 == 0)
                    {
                        secondBoatTiles += input.Length;
                    }
                    else
                    {
                        firstBoatTiles += input.Length;
                    }

                    if (firstBoatTiles>=50 || secondBoatTiles>=50)
                    {
                        break;
                    }
                }
                else
                {                   
                    firstBoatSymbol = (char)(firstBoatSymbol + 3);
                    secondBoatSymbol = (char)(secondBoatSymbol + 3);
                }
            }

            char winner = (firstBoatTiles > secondBoatTiles) ? firstBoatSymbol : secondBoatSymbol;

            Console.WriteLine(winner);   
        }
    }
}
