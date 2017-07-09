using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_PlayCatch
{
    public class PlayCatch
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int numException = 0;

            while (numException < 3)
            {
                string[] line = Console.ReadLine().Split();
                string command = line[0]; 

                try 
	            {
                    if (command == "Replace")
                    {
                        int index = int.Parse(line[1]);
                        int num = int.Parse(line[2]);
                        input[index] = num;
                    }
                    else if (command == "Print")
                    {
                        int startIndex = int.Parse(line[1]);
                        int endIndex = int.Parse(line[2]);
                        List<int> arr = input.GetRange(startIndex, endIndex - startIndex + 1);
                        Console.WriteLine(String.Join(", ", arr));
                    }
                    else if (command == "Show")
                    {
                        int index = int.Parse(line[1]);
                        Console.WriteLine(input[index]); 
                    }	
	            }
                catch (FormatException)
                {
                    numException++;
                    Console.WriteLine("The variable is not in the correct format!");
                }
                catch (ArgumentOutOfRangeException)
                {
                    numException++;
                    Console.WriteLine("The index does not exist!");
                }
                catch (ArgumentException)
                {
                    numException++;
                    Console.WriteLine("The index does not exist!");
                } 
            }

            Console.WriteLine(String.Join(", ", input));

        }
    }
}

