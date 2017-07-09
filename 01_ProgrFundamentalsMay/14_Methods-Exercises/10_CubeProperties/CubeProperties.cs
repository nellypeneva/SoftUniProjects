using System;

namespace _10_CubeProperties
{
    public class CubeProperties
    {
        public static void Main()
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            switch (parameter)
            {
                case "face":
                    {
                        Console.WriteLine("{0:f2}", FaceDiagonal(cubeSide));
                        break;
                    }
                case "space":
                    {
                        Console.WriteLine("{0:f2}", SpaceDiagonal(cubeSide));
                        break;
                    }
                case "volume":
                    {
                        Console.WriteLine("{0:f2}", Volume(cubeSide));
                        break;
                    }
                case "area":
                    {
                        Console.WriteLine("{0:f2}", Area(cubeSide));
                        break;
                    }
            }

        }

        public static double FaceDiagonal(double cubeSide)
        {
            return Math.Sqrt(2 * (cubeSide * cubeSide));
        }

        public static double SpaceDiagonal(double cubeSide)
        {
            return Math.Sqrt(3 * (cubeSide * cubeSide));
        }

        public static double Volume(double cubeSide)
        {
            return cubeSide * cubeSide * cubeSide;
        }

        public static double Area(double cubeSide)
        {
            return cubeSide * cubeSide * 6;
        }

    }
}