using System; 
namespace _05_BPMCounter
{
    class BPMCounter
    {
        static void Main()
        {
            int beatsPerMinute = int.Parse(Console.ReadLine());
            int numberOfBeats = int.Parse(Console.ReadLine());

            double bars = numberOfBeats / 4.0;
            bars = Math.Round(bars, 1); 
            double x = numberOfBeats / (double)beatsPerMinute; 
            int minutes = (int) x;
            double seconds = (x - minutes) * 60;

            Console.WriteLine("{0} bars - {1}m {2}s", bars, minutes, Math.Floor(seconds)); 
        }
    }
}
