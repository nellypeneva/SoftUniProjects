using System;
using System.Linq;

namespace _18_Debugging_SequenceOfCommands
{
    public class SequenceOfCommands
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                            .Split(ArgumentsDelimiter)
                            .Select(long.Parse)
                            .ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {

                int[] args = new int[2];
                string[] stringParams = command.Split(ArgumentsDelimiter);

                if (command.Contains("add") ||
                    //command.Contains("substract") || 
                    command.Contains("subtract") ||
                    command.Contains("multiply"))
                {
                    args[0] = int.Parse(stringParams[1]) - 1; //position - 1 == array index
                    args[1] = int.Parse(stringParams[2]);
                }

                PerformAction(array, stringParams[0], args);

                PrintArray(array);
                Console.WriteLine();

                command = Console.ReadLine();
            }
        }


        public static void PerformAction(long[] arr, string action, int[] args)
        {
            int pos = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    arr[pos] *= value;
                    break;
                case "add":
                    arr[pos] += value;
                    break;
                //case "substract":
                //arr[pos] -= value;
                //break;
                case "subtract":
                    arr[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    ArrayShiftRight(arr);
                    break;
            }

        }

        private static void ArrayShiftRight(long[] array)
        {
            long lastElement = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = lastElement;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long firstElement = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = firstElement;
        }

        public static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}