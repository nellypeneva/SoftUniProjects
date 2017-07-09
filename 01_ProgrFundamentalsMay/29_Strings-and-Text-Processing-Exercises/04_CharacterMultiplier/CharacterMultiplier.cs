using System; 

namespace _04_CharacterMultiplier
{
    public class CharacterMultiplier
    {
        public static void Main()
        { 
            string[] input =Console.ReadLine().Split(' ');
            string line1 = input[0];
            string line2 = input[1];

            int sum = CharMultiplier(line1, line2);
          
            Console.WriteLine(sum);            
        } 

        public static int CharMultiplier(string line1, string line2)
        {
            int sum = 0;
            int num = Math.Min(line1.Length, line2.Length);

            for (int i = 0; i < num; i++)
            {
                sum += line1[i] * line2[i];
            }

            string longerLine = line1;
            int length = line1.Length;

            if (line2.Length > line1.Length)
            {
                longerLine = line2;
                length = line2.Length;
            }

            for (int i = num; i < length; i++)
            {
                sum += longerLine[i];
            }

            return sum;
        }
    } 
}
