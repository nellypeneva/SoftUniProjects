using System; 

namespace _01_HornetWings
{
    public class HornetWings
    {
        public static void Main()
        {
            int wingFlaps = int.Parse(Console.ReadLine()); //n wing flaps
            double m = double.Parse(Console.ReadLine()); //distance, in meters, the hornet travels for 1000 wing flaps.
            int p = int.Parse(Console.ReadLine());  //or how many wing flaps he can make, before he stops to take a break and rest. A hornet rests for 5 seconds.

            double distance = (wingFlaps / 1000.0) * m;
            double secondsFlaps = wingFlaps / 100.00;
            double secondsRest = (wingFlaps / p) * 5;
            Console.WriteLine("{0:f2} m.", distance);
            Console.WriteLine("{0} s.", secondsRest + secondsFlaps);
        }
    }
}
