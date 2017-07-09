using System; 

namespace _01_SweetDessert
{
    public class SweetDessert
    {
        public static void Main()
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());

            decimal bananUnitPrice = decimal.Parse(Console.ReadLine());
            decimal eggsUnitPrice = decimal.Parse(Console.ReadLine());
            decimal berriesKgPrice = decimal.Parse(Console.ReadLine());

            int setsPortion = guests / 6;
            if (guests % 6 != 0)
            {
                setsPortion++;
            }

            decimal moneyNeeded = setsPortion * 2 * bananUnitPrice +
                                  setsPortion * 4 * eggsUnitPrice + 
                                  setsPortion * 0.2m * berriesKgPrice;
            
            if (cash - moneyNeeded >= 0)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", moneyNeeded);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", moneyNeeded - cash);
            }
        }
    }
}
