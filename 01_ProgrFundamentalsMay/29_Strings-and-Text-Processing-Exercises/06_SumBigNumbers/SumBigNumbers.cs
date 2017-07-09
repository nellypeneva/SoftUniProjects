using System; 
using System.Text; 

namespace _06_SumBigNumbers
{
    public class SumBigNumbers
    {
        public static void Main()
        {
            string first = Console.ReadLine().TrimStart('0');
            string second = Console.ReadLine().TrimStart('0');
            int pad = Math.Max(first.Length, second.Length);

            first = first.PadLeft(pad, '0');
            second = second.PadLeft(pad, '0');

            int transfer = 0;
            int remainder = 0;
            StringBuilder result = new StringBuilder();

            for (int i = first.Length - 1; i >= 0; i--)
            {
                int num1 = int.Parse(first[i].ToString());
                int num2 = int.Parse(second[i].ToString());
                int sum = num1 + num2 + transfer;
                transfer = sum / 10;
                remainder = sum % 10;

                result.Insert(0, remainder.ToString()); 
            }

            if (transfer != 0)
            {
                result.Insert(0, transfer.ToString());
            } 

            Console.WriteLine(result);
        }
    }
}
