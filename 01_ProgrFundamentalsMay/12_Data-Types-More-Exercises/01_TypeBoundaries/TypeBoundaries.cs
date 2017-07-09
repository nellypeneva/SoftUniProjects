﻿using System; 

namespace _01_TypeBoundaries
{
    public class TypeBoundaries
    {
        public static void Main()
        {
            //“int”, “uint”, “long”, “byte” and “sbyte”.
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                {
                    Console.WriteLine(int.MaxValue);
                    Console.WriteLine(int.MinValue);
                    break;
                }
                case "uint":
                {
                    Console.WriteLine(uint.MaxValue);
                    Console.WriteLine(uint.MinValue);
                    break;
                }
                case "long":
                {
                    Console.WriteLine(long.MaxValue);
                    Console.WriteLine(long.MinValue);
                    break;
                }
                case "byte":
                {
                    Console.WriteLine(byte.MaxValue);
                    Console.WriteLine(byte.MinValue);
                    break;
                }
                case "sbyte":
                {
                    Console.WriteLine(sbyte.MaxValue);
                    Console.WriteLine(sbyte.MinValue);
                    break;
                }
              
                default:
                    break;
            }
        }
    }
}
