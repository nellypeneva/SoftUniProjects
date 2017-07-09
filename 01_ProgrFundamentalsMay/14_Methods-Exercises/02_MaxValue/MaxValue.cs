using System; 

namespace _02_MaxValue
{
    class MaxValue
    {
        public static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = GetMax(num1, num2);
            Console.WriteLine(GetMax(num4, num3));
        }

        public static int GetMax(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }
            return b;
        }
    }
}
