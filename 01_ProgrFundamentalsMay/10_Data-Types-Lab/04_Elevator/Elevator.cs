using System; 

namespace _04_Elevator
{
    public class Elevator
    {
        public static void Main()
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int result = (int) Math.Ceiling(persons / (double)capacity);
            Console.WriteLine(result);
        }
    }
}
