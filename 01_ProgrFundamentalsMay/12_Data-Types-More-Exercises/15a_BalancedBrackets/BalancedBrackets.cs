using System;
using System.Collections.Generic; 

namespace _15a_BalancedBrackets
{
    class BalancedBrackets
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string lastBracket = string.Empty;
            bool balanced = true;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    if (lastBracket == "(")
                    {
                        balanced = false;
                        break;
                    }

                    lastBracket = "(";
                }

                if (input == ")")
                {
                    if (lastBracket != "(")
                    {
                        balanced = false;
                        break;
                    }

                    lastBracket = ")";
                }
            }

            if (lastBracket == "(")
            {
                balanced = false;
            }

            string result = (balanced) ? "BALANCED" : "UNBALANCED";
            Console.WriteLine(result);
        } 
    }
}
