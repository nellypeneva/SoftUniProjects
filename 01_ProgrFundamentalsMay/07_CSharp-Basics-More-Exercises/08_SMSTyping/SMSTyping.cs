using System;
using System.Text; 

namespace _08_SMSTyping
{
    class SMSTyping
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            StringBuilder builtString = new StringBuilder();

            for (int i = 0; i < num; i++)
            {
                int n = int.Parse(Console.ReadLine()); 

                if (n==0)
                {
                    builtString.Append(" ");
                }
                else if (n>0)
                {
                    int numDigits = (int)Math.Floor(Math.Log10(n) + 1);
                    int pow = numDigits - 1;
                    int firstDigit = n / (int) (Math.Pow(10,pow));
                    int offset = (firstDigit - 2) *  3;

                    if (firstDigit == 8 || firstDigit == 9)
                    {
                        offset++;
                    }

                    int index = offset + numDigits - 1; 
                    
                    builtString.Append(alphabet[index]);
                } 
            }

            Console.WriteLine(builtString.ToString());
        }
    }
}
