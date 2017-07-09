using System; 
using System.Linq; 

namespace _02_ArrayModifier
{
    public class ArrayModifier
    {
        public static void Main()
        {

            long[] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();

            string command = Console.ReadLine();
            while (command!="end")
            {
                string[] parameters = command.Split();

                switch (parameters[0])
                {
                    case "swap": 
                    {
                        int index1 = int.Parse(parameters[1]);
                        int index2 = int.Parse(parameters[2]);
                        Swap(index1, index2, arr);
                        break; 
                    }
                    case "multiply": 
                    {
                        int index1 = int.Parse(parameters[1]);
                        int index2 = int.Parse(parameters[2]);
                        Multiply(index1, index2, arr);
                        break; 
                    }
                    case "decrease": 
                    { 
                        DecreaseElements(arr); 
                        break; 
                    }
                    default:
                        break;
                } 

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", arr));
        }

        private static void Multiply(int index1, int index2, long[] arr)
        {
            if (index1 >=0 && index1 < arr.Length && index2 >=0 && index2 < arr.Length)
            {
                arr[index1] = arr[index1] * arr[index2];
            }
        }

        private static void Swap(int index1, int index2, long[] arr)
        {
            if (index1 >= 0 && index1 < arr.Length && index2 >= 0 && index2 < arr.Length)
            {
                long temp = arr[index1];
                arr[index1] = arr[index2];
                arr[index2] = temp;
            }
        }

        private static void DecreaseElements(long[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]--;
            }
        }
    }
}
