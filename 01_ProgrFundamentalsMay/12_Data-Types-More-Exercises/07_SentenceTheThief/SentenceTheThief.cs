using System; 

namespace _07_SentenceTheThief
{
    class SentenceTheThief
    {
        static void Main()
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

                if (currentNum <= maxValue && currentNum >= minValue && currentNum > id)
                {
                    id = currentNum;
                }
            }

            var result = Math.Ceiling(Math.Abs(id / 127.0)); 

            if (id < 0)
            {
                result = Math.Ceiling(Math.Abs(id / 128.0));
            }

            string year = "years";

            if (result==1)
            {
                year = "year";
            }

            Console.WriteLine("Prisoner with id {0} is sentenced to {1} {2}", id, result, year); 
        }
    }
}
