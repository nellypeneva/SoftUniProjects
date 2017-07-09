using System;
class ComparingFloats
{
    static void Main()
    {
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        double diff = Math.Abs(number1 - number2);
        if (diff < eps)
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
}
