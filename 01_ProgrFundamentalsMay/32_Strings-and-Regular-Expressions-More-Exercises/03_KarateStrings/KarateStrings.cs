using System;
using System.Collections.Generic; 
namespace _03_KarateStrings
{
    public class KarateStrings
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            int power = 0;
           
            for (int i = 0; i < input.Length; i++)
            {
                if ('>' == input[i])
                {
                    if (i + 1 < input.Length)
                    {
                        power += int.Parse(input[i + 1].ToString());

                        if (power > 0)
                        {
                            input = input.Remove(i + 1, 1);
                            power--;
                        }                  
                    } 
                }
                else if (power > 0)
                {
                    input = input.Remove(i, 1);
                    power--;
                    i--;
                }
            }

            Console.WriteLine(input);            
        }
    }
} 