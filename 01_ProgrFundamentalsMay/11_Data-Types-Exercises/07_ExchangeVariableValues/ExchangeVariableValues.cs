using System;
class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5; //int.Parse(Console.ReadLine());
        int b = 10;//int.Parse(Console.ReadLine());
        Console.WriteLine("Before:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        int c = b;
        b = a;
        a = c;
        Console.WriteLine("After:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
} 
