using System;
class BooleanVariable
{
    static void Main()
    {
        bool firstVar = Convert.ToBoolean(Console.ReadLine());
        string result = (firstVar) ? "Yes" : "No";
        Console.WriteLine(result);
    }
} 
