using System; 

namespace _04_BeverageLabels
{
    class BeverageLabels
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            double k = volume/100.00;

            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", energy * k, sugar * k);
        }
    }
}
 