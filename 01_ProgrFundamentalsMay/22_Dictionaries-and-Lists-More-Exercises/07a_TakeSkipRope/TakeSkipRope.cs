using System;
using System.Collections.Generic;
using System.Linq; 

namespace _07a_TakeSkipRope
{
    class TakeSkipRope
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<int> skipList = new List<int>();
            List<int> takeList = new List<int>();
            List<char> text = new List<char>();
            int index = 0;

            foreach (var symbol in input)
            {
                if (char.IsDigit(symbol))
                {
                    if (index % 2 == 0)
                    {
                        takeList.Add(int.Parse(symbol.ToString()));
                    }
                    else
                    {
                        skipList.Add(int.Parse(symbol.ToString()));
                    }

                    index++;
                }
                else
                {
                    text.Add(symbol);
                } 
            }
 
            string result = String.Empty;
            int skipTotal = 0;

            for (int i = 0; i < skipList.Count; i++)
            {
                char[] charArr = text.Skip(skipTotal).Take(takeList[i]).ToArray();

                skipTotal += skipList[i] + takeList[i];

                string str = new string(charArr);

                result += str;
            }

            Console.WriteLine(result); 
        }
    }
}

            
