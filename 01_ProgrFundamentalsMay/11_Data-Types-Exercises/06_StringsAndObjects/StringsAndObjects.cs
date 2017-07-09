using System;
class StringsAndObjects
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "World";
        object concatenatedString = str1 + " " + str2;
        string str3 = (string)concatenatedString;
        Console.WriteLine(str3);
    }
}