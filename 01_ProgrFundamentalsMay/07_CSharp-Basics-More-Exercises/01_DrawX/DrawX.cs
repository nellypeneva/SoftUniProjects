using System; 

namespace _01_DrawX
{
    class DrawX
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int middle = n / 2 + 1;
            int offset=0;

            for (int i = 1; i < middle; i++)
            {
                Console.WriteLine("{0}x{1}x{2}", new String(' ', offset), new String(' ', n - 2 - 2 * offset), new String(' ', offset));
                offset++;
            }

            Console.WriteLine("{0}x{1}", new String(' ', offset), new String(' ', offset));
            offset--; 

            for (int i = middle+1; i <= n; i++)
            {
                Console.WriteLine("{0}x{1}x{2}", new String(' ', offset), new String(' ', n - 2 - 2 * offset), new String(' ', offset));
                offset--;  
            }
             
        }
    }
}
