using System;
class RectangleProperties
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double perimeter, area, diagonal;
        perimeter = 2 * (width + height);
        area = width * height;
        diagonal = Math.Sqrt(width * width + height * height);
        Console.WriteLine(perimeter + Environment.NewLine + area + Environment.NewLine + diagonal);
    }
} 
