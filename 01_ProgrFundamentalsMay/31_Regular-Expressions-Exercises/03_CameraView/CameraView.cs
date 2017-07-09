using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text.RegularExpressions; 

namespace _03_CameraView
{
    public class CameraView
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            int skip = nums[0];
            int take = nums[1];
            var list = new List<string>();

            string pattern = @"(\|<\w+)"; 
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                string value = match.Groups[0].Value;
                string result = String.Join("", value.Skip(skip + 2).Take(take));
                list.Add(result);
            }

            Console.WriteLine(String.Join(", ", list)); 
        }
    }
} 