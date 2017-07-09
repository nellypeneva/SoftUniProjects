using System;
using System.Collections.Generic;
using System.Linq; 

namespace _05_ArrayManipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string[] parameters = Console.ReadLine().Split(' ');

                if (parameters[0] == "print")
                {
                    Console.WriteLine("[{0}]", string.Join(", ", input));
                    break;
                }
                else if (parameters[0] == "add")
                {
                    var index = int.Parse(parameters[1]);
                    var value = int.Parse(parameters[2]);

                    if (index >= 0 && index <= input.Count)
                    {
                        input.Insert(index, value);
                    }
                }
                else if (parameters[0] == "remove")
                {
                    var index = int.Parse(parameters[1]);

                    if (index >= 0 && index < input.Count)
                    {
                        input.RemoveAt(index);
                    }
                }
                else if (parameters[0] == "contains")
                {
                    int value = int.Parse(parameters[1]);
                    Console.WriteLine(input.IndexOf(value));
                }
                else if (parameters[0] == "sumPairs")
                {
                    sumPairs(input);
                }
                else if (parameters[0] == "shift")
                {
                    int shifts = int.Parse(parameters[1]);

                    //for (int i = 0; i < shifts; i++)
                    //{
                    //    rotateLeft(input);
                    //}

                    ShiftLeft(input, shifts);
                }
                else if (parameters[0] == "addMany")
                {
                    int index = int.Parse(parameters[1]);

                    if (index > input.Count || index < 0) //if index in range or = ednIndex+1
                    {
                        input.AddRange(parameters.Skip(2).Select(int.Parse));
                    }
                    else // do we need to add the range at the end of the list if index is out of range ??
                    {
                        input.InsertRange(index, parameters.Skip(2).Select(int.Parse));
                    }
                }
            }
        }

        public static void sumPairs(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                numbers[i] += numbers[i + 1];
                numbers.RemoveAt(i + 1);
            }
        }

        public static void rotateLeft(List<int> arr)
        {
            int firstNum = arr[0];
            for (int i = 0; i < arr.Count - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Count - 1] = firstNum;
        }

        public static void ShiftLeft(List<int> numbers, int shifts)
        {
            if (shifts >= numbers.Count)
            {
                shifts = shifts % numbers.Count;
            }

            List<int> range = numbers.GetRange(0, shifts);
            numbers.RemoveRange(0, shifts);
            numbers.AddRange(range);
        }
    }
}
