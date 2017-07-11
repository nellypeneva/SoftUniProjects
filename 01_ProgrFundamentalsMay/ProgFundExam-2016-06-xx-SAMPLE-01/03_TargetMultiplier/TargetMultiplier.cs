using System; 
using System.Linq; 

namespace _03_TargetMultiplier
{
    public class TargetMultiplier
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0]; //i
            int cols = dimensions[1]; //j

            int[,] twoDimArr = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] line = Console.ReadLine().Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    twoDimArr[i,j]=line[j];
                }
 
            }

            int[] cell = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int cellRow = cell[0];
            int cellCol = cell[1];
            int cellValue = twoDimArr[cellRow, cellCol]; 

            int startRow = (cellRow - 1 >= 0) ? cellRow - 1 : 0;
            int endRow = (cellRow + 1 < rows) ? cellRow + 1 : rows - 1;
            int startCol = (cellCol - 1 >= 0) ? cellCol - 1 : 0;
            int endCol = (cellCol + 1 < cols) ? cellCol + 1 : cols - 1;

            int sum = 0;
            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startCol; j <= endCol; j++)
                {
                    if (i == cellRow && j == cellCol)
                    {
                        continue;
                    }
                    sum += twoDimArr[i, j];
                    twoDimArr[i, j] *= cellValue;
                }
            }

            twoDimArr[cellRow, cellCol] *= sum;

            printArray(twoDimArr); 
        }

        private static void printArray(int[,] twoDimArr)
        {
            for (int i = 0; i < twoDimArr.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimArr.GetLength(1); j++)
                {
                    Console.Write("{0} ", twoDimArr[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
