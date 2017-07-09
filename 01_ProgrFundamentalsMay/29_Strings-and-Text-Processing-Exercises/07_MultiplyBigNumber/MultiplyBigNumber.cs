using System; 
using System.Text; 

namespace _07_MultiplyBigNumber
{
    public class MultiplyBigNumber
    {
        public static void Main()
        {
            string first = Console.ReadLine().TrimStart('0');
            string second = Console.ReadLine().TrimStart('0');

            if (first == "0" || second == "0" || first == String.Empty || second == String.Empty)
            {
                Console.WriteLine("0");
                return;
            }

            string finalResult = String.Empty;
            int padding = 0;

            for (int i = first.Length - 1; i >= 0; i--)
            {
                StringBuilder result = new StringBuilder();
                int transfer = 0;
                int remainder = 0;
              

                for (int j = second.Length - 1; j >= 0; j--)
                {
                    int sum = int.Parse(first[i].ToString()) * int.Parse(second[j].ToString()) + transfer;
                    transfer = sum / 10;
                    remainder = sum % 10;
                    result.Insert(0, remainder.ToString());
                }

                if (transfer != 0)
                {
                    result.Insert(0, transfer.ToString());
                }
                                
                result.Append( new String('0',padding) );  
                padding++;

                string sumResult = result.ToString();

                finalResult = SumBigNumbers( finalResult, sumResult);

            }

            Console.WriteLine(finalResult);
        }
         

        public static string SumBigNumbers(string first, string second)
        {
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
            
            return result.ToString();
        }
    }
}


