using System; 
using System.Linq; 

namespace _02_Ladybugs
{
    class Ladybugs
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (indexes.Contains(i))
                {
                    arr[i] = 1;
                }
            }
 
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
	            {
                    break;
	            }

                string[] parameters = input.Split();
                int index = int.Parse(parameters[0]);
                string direction = parameters[1];
                int positions = int.Parse(parameters[2]);

                if (index < 0 || index >= arr.Length || arr[index] == 0)
                {
                    continue;
                }

                arr[index] = 0;
                int nextIndex = index;

                do
                {
                    if (direction == "right")
                    {
                        nextIndex += positions;
                    }
                    else
                    {
                        nextIndex -= positions;
                    }

                } 
                while (nextIndex >= 0 && nextIndex < arr.Length && 1 == arr[nextIndex] );

                if (nextIndex < arr.Length && nextIndex >= 0)
                {
                    arr[nextIndex] = 1;
                }
 
            }

            Console.WriteLine(String.Join(" ", arr));
        } 
    }
}
 