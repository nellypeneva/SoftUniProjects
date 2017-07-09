using System; 

namespace _02_AdvertisementMessage
{
    class AdvertisementMessage
    {
        static void Main()
        {
            var phrases = new string[] { "Excellent product.", 
                                        "Such a great product.", 
                                        "I always use that product.", 
                                        "Best product of its category.", 
                                        "Exceptional product.", 
                                        "I can’t live without this product." };
            
            var events = new string[]{"Now I feel good.", 
                                    "I have succeeded with this product.", 
                                    "Makes miracles. I am happy of the results!", 
                                    "I cannot believe but now I feel awesome.", 
                                    "Try it yourself, I am very satisfied.", 
                                    "I feel great!"}; 

            var authors = new string[]{"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            var towns = new string[] {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            int n = int.Parse(Console.ReadLine());

            var random = new Random();

            for (int i = 0; i < n; i++)
            {
                var phraseIndex = random.Next(0, phrases.Length);
                var eventIndex = random.Next(0, events.Length);
                var authorIndex = random.Next(0, authors.Length);
                var townIndex = random.Next(0, towns.Length);

                Console.WriteLine("{0} {1} {2} - {3}",
                                    phrases[phraseIndex], events[eventIndex], authors[authorIndex], towns[townIndex]);
            }
        }
    }
}
