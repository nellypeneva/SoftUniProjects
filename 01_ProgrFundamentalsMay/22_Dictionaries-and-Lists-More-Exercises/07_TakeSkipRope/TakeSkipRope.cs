using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 

namespace _07_TakeSkipRope
{
    public class TakeSkipRope
    {
        public static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();  
            int[] numbersList = input.Where(x => (true == char.IsDigit(x))).Select(x => Convert.ToInt32(x.ToString())).ToArray();            
            char[] nonNumbersList = input.Where(x => (false == char.IsDigit(x))).ToArray();
 
            int[] takeList = numbersList.Where((item, index) => (index + 1) % 2 != 0).ToArray(); //odds starting count from 1
            int[] skipList = numbersList.Where((item, index) => (index + 1) % 2 == 0).ToArray(); //evens starting count from 1

            StringBuilder builder = new StringBuilder();

            int skippedNum = 0;
             

            for (int i = 0; i < takeList.Length; i++)
            {
                int skip = (i < skipList.Length) ? skipList[i] : 0;

                var result = nonNumbersList.Skip(skippedNum).Take(takeList[i]).ToArray();
                string text = String.Join("", result);
                builder.Append(result);

                skippedNum += skip + takeList[i];
            }

            Console.WriteLine(builder.ToString());
        }
    }
} 