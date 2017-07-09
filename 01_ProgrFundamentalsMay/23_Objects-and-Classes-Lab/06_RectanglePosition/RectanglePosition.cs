using System;
using System.Linq; 

namespace _06_RectanglePosition
{
    public class RectanglePosition
    {
        public static void Main()
        {
            int[] firstRectAttributes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondRectAttributes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           
            Rectangle firstRect = new Rectangle
            {               
                Left = firstRectAttributes[0],
                Top = firstRectAttributes[1],
                Width = firstRectAttributes[2],
                Height = firstRectAttributes[3],
            };

            Rectangle secondRect = new Rectangle
            {
                Left = secondRectAttributes[0],
                Top = secondRectAttributes[1],
                Width = secondRectAttributes[2],
                Height = secondRectAttributes[3],
            };

            string result = (FirstIsInsideSecond(firstRect, secondRect)) ? "Inside" : "Not inside";

            Console.WriteLine(result);
        }

        public static bool FirstIsInsideSecond(Rectangle first, Rectangle second)
        {
            bool result = first.Left >= second.Left && first.Right <= second.Right &&
                           first.Bottom >= second.Bottom && first.Top <= second.Top;

           return result;
        }
    }
}
