using System;
using System.Collections.Generic;
using System.Linq; 

namespace _02_ManipulateArray
{
    public class ManipulateArray
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            byte n = byte.Parse(Console.ReadLine());


            for (byte i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                
                if (command=="Reverse")
                {
                    input = input.Reverse().ToArray();
                }
                else if (command=="Distinct")
	            {
                    input=input.Distinct().ToArray();
	            }
                else if (command.Contains("Replace"))
                {
                    string[] parameters = command.Split(' ');
                    int index = int.Parse(parameters[1]);
                    input[index]=  parameters[2];
                }
            }

            Console.WriteLine(String.Join(", ", input));
        }
    }
}
