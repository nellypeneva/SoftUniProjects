using System; 

namespace _08_PersonalException
{
    public class PersonalException
    {
        public static void Main()
        {
            try
            {
                while (true)
                { 
                    int number = int.Parse(Console.ReadLine());

                    if (number < 0)
                    {
                        throw new NegativeException();
                    }

                    Console.WriteLine(number); 
                }
            }
            catch (NegativeException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }  
        } 
    }
}
