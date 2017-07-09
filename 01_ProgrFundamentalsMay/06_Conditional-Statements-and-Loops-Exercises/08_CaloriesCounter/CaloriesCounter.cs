using System; 

namespace _08_CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int calories = 0;

            for (int i = 0; i < num; i++)
            {
                string ingredient = Console.ReadLine().Trim().ToLower();

                switch (ingredient)
                {
                    case "cheese": { calories+= 500; break; }
                    case "tomato sauce": { calories += 150; break; }
                    case "salami": { calories += 600; break; }
                    case "pepper": { calories += 50; break; }
                    default: break; 
                }
            }

            Console.WriteLine("Total calories: {0}", calories);
        }
    }
}
