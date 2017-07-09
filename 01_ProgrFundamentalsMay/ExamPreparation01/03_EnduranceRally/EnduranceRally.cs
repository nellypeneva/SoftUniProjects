using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_EnduranceRally
{
    public class EnduranceRally
    {
        public static void Main()
        {

            string[] drivers = Console.ReadLine().Split(' ').ToArray();
            double[] zonesFluel = Console.ReadLine().Split(' ').Select(double.Parse).ToArray(); //Track layout 
            int[] checkpointIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < drivers.Length; i++)
            {
                string name= drivers[i];
                double startingFluel = (double)name[0];
                int index = 0;

                while (startingFluel > 0 && index < zonesFluel.Length) 
                {
                    if (checkpointIndexes.Contains(index))
                    {
                        startingFluel += zonesFluel[index];
                    }
                    else
                    {
                        startingFluel -= zonesFluel[index];
                    }

                    index++; 
                }

                string result = (startingFluel > 0) ? 
                                String.Format("{0} - fuel left {1:f2}", name, startingFluel) :
                                String.Format("{0} - reached {1}", name, index -1);

                Console.WriteLine(result);
            }
        }
    }
}
