using System; 

namespace _01_DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} {1} {2} {3}", num1.ToString("D4"), num2.ToString("D4"), num3.ToString("D4"), num4.ToString("D4"));
        }
    }
}
