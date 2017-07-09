using System; 

namespace _08_HouseBuilder
{
    class HouseBuilder
    {
        static void Main()
        { 
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            sbyte price1;
            int price2;
            long totalPrice = 0;

            if (sbyte.TryParse(input1, out price1) && int.TryParse(input2, out price2))
            {
                totalPrice = 4L * price1 + 10L * price2;
            }
            else if (int.TryParse(input1, out price2) && sbyte.TryParse(input2, out price1))
            {
                totalPrice = 4L * price1 + 10L * price2;
            }

            Console.WriteLine(totalPrice);
        }
    }
}
