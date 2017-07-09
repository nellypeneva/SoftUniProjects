using System; 

namespace _06_CatchTheThief
{
    public class CatchTheThief
    {
        public static void Main()
        {
            string type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            long minValue = long.MinValue;
            long maxValue = long.MaxValue;

            switch (type)
            {
                case "sbyte":
                    {
                        minValue = sbyte.MinValue;
                        maxValue = sbyte.MaxValue;
                        break;
                    }
                case "int":
                    {
                        minValue = int.MinValue;
                        maxValue = int.MaxValue;
                        break;
                    } 
                default:
                    break;
            } 

            long id = long.MinValue;  

            for (int i = 0; i < n; i++)
            { 
                long currentNum = long.Parse(Console.ReadLine());

                if (currentNum <=maxValue &&  currentNum>=minValue && currentNum > id)
                {
                    id = currentNum;
                } 
            }

            Console.WriteLine(id);

        }
    }
}
